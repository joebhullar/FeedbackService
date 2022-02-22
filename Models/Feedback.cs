using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackService.Models
{
    public class Feedback
    {
        [Key]
        public int FeedbackId { get; set; }
        public string FeedbackGiven { get; set; }
        public string FeedbackBy { get; set; }
        public DateTime FeedbackDate { get; set; }
    }
}
