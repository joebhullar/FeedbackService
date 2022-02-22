using FeedbackService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackService.Repository
{
    public interface IFeedbackRespository
    {
        IEnumerable<Feedback> GetFeedbacks();
        int CreateFeedback(Feedback feedback);
    }
}
