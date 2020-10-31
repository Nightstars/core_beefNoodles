using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace core_beefNoodles.Controllers
{
   // public class TestController
   //[Controller]
   // public class Test
    public class Test: Controller
    {
        public ActionResult Index()
        {
            return Content("Hello From Test Index");
        }

        public string About()
        {
            return "Hello From Test About";
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
