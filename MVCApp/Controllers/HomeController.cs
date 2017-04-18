using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using MVCApp.Services;
using MVCApp.ViewModels;

namespace MVCApp.Controllers
{
    
    public class HomeController : Controller
    {
        private IMyInjectedService myService;

        public HomeController(IMyInjectedService myService)
        {
            this.myService = myService;
        }

        public IActionResult Index()
        {
            ViewBag.myObject = this.myService;
            return View();
        }

        public IActionResult FirstView()
        {
//            var model = new MyData{ MyId = 3, MyValue = "My View"};

            var model = new List<MyData>
            {
                new MyData {MyId = 1, MyValue = "First"},
                new MyData {MyId = 2, MyValue = "Second"}
            };

            var viewmodel = new FirstViewViewModel();
            viewmodel.MyType = model;

            return View(viewmodel);
        }
        
        public ContentResult IdRoute()
        {
            return Content("Attribute Routing");
        }

        //Return Types
        public JsonResult MyObject()
        {
            var mymodel = new MyData{ MyId = 1, MyValue = "My first Value"};

            return Json(mymodel);
        }
    }
}
