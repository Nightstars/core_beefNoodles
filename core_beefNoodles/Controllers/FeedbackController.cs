using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core_beefNoodles.Models;
using Microsoft.AspNetCore.Mvc;

namespace core_beefNoodles.Controllers
{
    public class FeedbackController : Controller
    {
        private IFeedbackRepositroy _feedbackRepositroy;

        public FeedbackController(IFeedbackRepositroy feedbackRepositroy)
        {
            _feedbackRepositroy = feedbackRepositroy;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedback.CreateDataUTC = DateTime.Now;
                _feedbackRepositroy.AddFeedback(feedback);
                return RedirectToAction("FeedbackComplete");
            }
            return View();
        }

        public IActionResult FeedbackComplete()
        {
            return View();
        }

    }
}
