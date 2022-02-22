using FeedbackService.Models;
using FeedbackService.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        readonly IFeedbackRespository feedbackRepository;
        public FeedbackController(IFeedbackRespository _ifeedbackRespository)
        {
            this.feedbackRepository = _ifeedbackRespository;
        }
        [HttpGet("FeedbackList")]
        public IActionResult GetFeedbackList()
        {
            return Ok(feedbackRepository.GetFeedbacks());
        }
        [HttpPost("CreateFeedback")]
        public ActionResult CreateFeedback(Feedback objFeedback)
        {
            return Ok(feedbackRepository.CreateFeedback(objFeedback));
        }

    }
}
