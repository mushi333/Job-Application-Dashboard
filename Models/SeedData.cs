using System;
using JobApplicationDashboard.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace JobApplicationDashboard.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (
            var context = new JobApplicationDashboardContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<JobApplicationDashboardContext>
                >()
            )
        )
        {
            // Look for any movies.
            if (context.Application.Any())
            {
                return; // DB has been seeded
            }
            context
                .Application
                .AddRange(
                    new Application
                    {
                        Company = "Nab",
                        Role = "Graduate Program",
                        Date = DateTime.Parse("2024-02-27"),
                        Resource = "Tech",
                        Status = "Applied",
                        Other = ""
                    },
                    new Application
                    {
                        Company = "CommBank",
                        Role = "Graduate Program",
                        Date = DateTime.Parse("2024-02-27"),
                        Resource = "Tech",
                        Status = "Applied",
                        Other = ""
                    },
                    new Application
                    {
                        Company = "PWC",
                        Role = "Graduate Program",
                        Date = DateTime.Parse("2024-02-27"),
                        Resource = "Tech",
                        Status = "Applied",
                        Other = ""
                    },
                    new Application
                    {
                        Company = "KPMG",
                        Role = "Graduate Program",
                        Date = DateTime.Parse("2024-02-27"),
                        Resource = "Tech",
                        Status = "Applied",
                        Other = ""
                    }
                );
            context.SaveChanges();
        }
    }
}
