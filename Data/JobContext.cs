using Microsoft.EntityFrameworkCore;
using JobSeeker.Models;
namespace JobSeeker.Data
{
    public class JobContext:DbContext
    {
        public JobContext(DbContextOptions<JobContext> options) : base(options) { }

        public DbSet<Job> Job { get; set; }

    }
}
