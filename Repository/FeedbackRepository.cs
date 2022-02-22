using FeedbackService.EntityFramework;
using FeedbackService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackService.Repository
{
    public class FeedbackRepository : IFeedbackRespository
    {
        readonly ApplicationDbContext applicationDbContext;
        public FeedbackRepository(ApplicationDbContext _applicationDbContext)
        {
            this.applicationDbContext = _applicationDbContext;
        }
        public int CreateFeedback(Feedback feedback)
        {
            this.applicationDbContext.Add(feedback);
            return this.applicationDbContext.SaveChanges();
        }

        public IEnumerable<Feedback> GetFeedbacks()
        {
            return this.applicationDbContext.Feedbacks.ToList();
        }
    }
}
