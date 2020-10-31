using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_beefNoodles.Models
{
    public interface IFeedbackRepositroy
    {
        IEnumerable<Feedback> GetAllFeedbacks();
        void AddFeedback(Feedback feedback);
    }
}
