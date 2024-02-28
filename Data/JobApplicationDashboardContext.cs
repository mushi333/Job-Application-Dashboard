using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobApplicationDashboard.Models;
using Microsoft.EntityFrameworkCore;

namespace JobApplicationDashboard.Data
{
    public class JobApplicationDashboardContext : DbContext
    {
        public JobApplicationDashboardContext(
            DbContextOptions<JobApplicationDashboardContext> options
        )
            : base(options) { }

        public DbSet<JobApplicationDashboard.Models.Application> Application { get; set; } =
            default!;
    }
}
