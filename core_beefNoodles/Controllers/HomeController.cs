using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using core_beefNoodles.Models;
using core_beefNoodles.ViewModels;

namespace core_beefNoodles.Controllers
{
    //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private INoodleRepository _noodleRepository;
        private IFeedbackRepositroy _FeedbackRepositroy;

        public HomeController(ILogger<HomeController> logger,INoodleRepository noodleRepository, IFeedbackRepositroy FeedbackRepositroy)
        {
            _logger = logger;
            _noodleRepository = noodleRepository;
            _FeedbackRepositroy = FeedbackRepositroy;
        }

        public IActionResult Index()
        {
            var viewModel = new HomeViewModel
            {
                noodles = _noodleRepository.GetAllNoodles().ToList(),
                feedbacks = _FeedbackRepositroy.GetAllFeedbacks().ToList()
            };
            return View(viewModel);
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

        public IActionResult Detail(int id)
        {
            return View(_noodleRepository.GetNoodleById(id));
        }
    }
}
