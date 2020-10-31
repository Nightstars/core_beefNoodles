using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_beefNoodles.Models
{
    public class MockFeedbackRepository : IFeedbackRepositroy
    {
        public List<Feedback> _feedbacks;

        public MockFeedbackRepository()
        {
            if(_feedbacks==null)
            {
                InitializeFeedback();
            }
        }

        public void AddFeedback(Feedback feedback)
        {
            _feedbacks.Add(feedback);
        }

        public IEnumerable<Feedback> GetAllFeedbacks()
        {
            return _feedbacks;
        }

        private void InitializeFeedback()
        {
            _feedbacks = new List<Feedback>
            {
                new Feedback{ Id=1,Name="阿莱克斯",Email="noname@hotmail.com",CreateDataUTC=new DateTime(2020-10-31),Message="很好吃"},
                new Feedback{ Id=2,Name="莱克斯",Email="noname@hotmail.com",CreateDataUTC=new DateTime(2020-10-31),Message="很好吃"},
                new Feedback{ Id=3,Name="克斯",Email="noname@hotmail.com",CreateDataUTC=new DateTime(2020-10-31),Message="很好吃"},
                new Feedback{ Id=4,Name="斯",Email="noname@hotmail.com",CreateDataUTC=new DateTime(2020-10-31),Message="很好吃"}
            };
        }
    }
}
