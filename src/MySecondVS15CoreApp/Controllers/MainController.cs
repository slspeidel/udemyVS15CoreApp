using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySecondVS15CoreApp.Models;
using MySecondVS15CoreApp.Interfaces;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MySecondVS15CoreApp.Controllers
{
    public class MainController : Controller
    {
        private readonly IFirstClass _firstClass;
        private IMyInjectedService _service;
        public MainController(IFirstClass firstClass, IMyInjectedService service)
        {
            _firstClass = firstClass;
            _firstClass.Value = "big";
            _service = service;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            //ViewBag.Value = _firstClass.Value;
            ViewBag.myServiceObject = _service;
            
            return View(_firstClass);
        }
    }
}
