using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core_beefNoodles.Models;

namespace core_beefNoodles.ViewModels
{
    public class HomeViewModel
    {
        public IList<Noodle> noodles { get; set; }
        public IList<Feedback> feedbacks { get; set; }
    }
}
