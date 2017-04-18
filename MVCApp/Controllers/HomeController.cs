using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FirstView()
        {
            var model = new MyData{ MyId = 3, MyValue = "My View"};

            return View(model);
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
