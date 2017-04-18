using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
    [Route("[Controller]")]
    public class HomeController : Controller
    {
        [Route("[Action]")]
        public IActionResult Index()
        {
            return View();
        }


        [Route("[Action]")]
        public string IdRoute()
        {
            return "Attribute Routing";
        }
    }
}
