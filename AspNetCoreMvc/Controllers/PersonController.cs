using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMvc.Models;

namespace AspNetCoreMvc.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            var people = new List<Person>
            {
                new Person { Name = "CoDy" },
                new Person { Name = "cOdY" },
                new Person { Name = "CodY" },
                new Person { Name = "cODy" },
                new Person { Name = "CODy" },
                new Person { Name = "cODY" },
                new Person { Name = "PLZ SEND HLP" }
            };   
           
            return View(people);
        }
    }
}