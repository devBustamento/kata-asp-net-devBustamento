using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Itb.Shared
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        int DeleteProduct(int id);
        int UpdateProduct(Product prod);
        int CreateProduct(Product prod);
    }
}
