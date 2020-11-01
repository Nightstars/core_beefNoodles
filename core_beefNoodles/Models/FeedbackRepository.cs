using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_beefNoodles.Models
{
    public class FeedbackRepository : IFeedbackRepositroy
    {
        private readonly AppDbContext _appDbContext;

        public FeedbackRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddFeedback(Feedback feedback)
        {
            _appDbContext.Feedbacks.Add(feedback);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Feedback> GetAllFeedbacks()
        {
            return _appDbContext.Feedbacks;
        }
    }
}
