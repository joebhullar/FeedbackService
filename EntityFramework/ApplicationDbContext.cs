using FeedbackService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackService.EntityFramework
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions opt): base(opt)
        {

        }
        public DbSet<Feedback> Feedbacks { get; set; }
    }

}
