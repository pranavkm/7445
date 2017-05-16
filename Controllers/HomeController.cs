using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _6237.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost("api")]
        public string Post(Person person) => person.Name;
    }

    public class Person
    {
        public string Name { get; set; }
    }
}
