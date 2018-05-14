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
                new Person { Name = "WHAT" },
                new Person { Name = "THE HELL" },
                new Person { Name = "IS" },
                new Person { Name = "REFLECTION" },
                new Person { Name = "IoC/DI" },
                new Person { Name = "MVC" },
                new Person { Name = "PLZ SEND HLP" }
            };   
           
            return View(people);
        }
    }
}