using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using core_beefNoodles.Models;

namespace core_beefNoodles.Controllers
{
    //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private INoodleRepository _noodleRepository;

        public HomeController(ILogger<HomeController> logger,INoodleRepository noodleRepository)
        {
            _logger = logger;
            _noodleRepository = noodleRepository;
        }

        public IActionResult Index()
        {
            var noodles=_noodleRepository.GetAllNoodles();
            return View(noodles);
        }

        public string About()
        {
            return "Hello from About";
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
