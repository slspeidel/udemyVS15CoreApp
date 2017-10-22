using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MySecondVS15CoreApp.Controllers
{
    public class Main : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.value = "My first MVC Route!";
            return View();
        }
    }
}
