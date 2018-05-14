using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Itb.Shared;

namespace Itb.Repositories 
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn; 
        }

        public int CreateProduct(Product prod)
        {
            using (var conn = _conn)
            {
                conn.Open();
                return conn.Execute("INSTER INTO product (Name) VALUES (@Name)", prod);
            }
        }

        public int DeleteProduct(int id)
        {
            using (var conn = _conn)
            {
                conn.Open();
                return conn.Execute("DELETE FROM product WHERE ProductId = @Id", new { id });
            }
        }

        public int UpdateProduct(Product prod)
        {
            using (var conn = _conn)
            {
                conn.Open();
                return conn.Execute("UPDAGE product SET Name = @Name WHERE ProductId = @id", prod);
            }
        }

        public Product GetProduct(int id)
        {
            using (var conn = _conn)
            {
                conn.Open();
                return conn.Query<Product>("SELECT *, ProductId FROM Product as Id WHERE ProductId = @Id").FirstOrDefault();
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            using (var conn = _conn)
            {
                conn.Open();
                return conn.Query<Product>("SELECT *, ProductId FROM Product as Id WHERE ProductId = @Id");
            }
        }
    }
}
