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
                        Company = "TechVantage",
                        Role = "Software Engineer",
                        Date = DateTime.Parse("2024-03-01"),
                        Resume = "Tech",
                        Status = "Applied",
                        Other = ""
                    },
                    new Application
                    {
                        Company = "DataCom",
                        Role = "Data Analyst",
                        Date = DateTime.Parse("2024-02-29"),
                        Resume = "Tech",
                        Status = "Applied",
                        Other = ""
                    },
                    new Application
                    {
                        Company = "InnoTech Solutions",
                        Role = "Product Manager",
                        Date = DateTime.Parse("2024-02-28"),
                        Resume = "Tech",
                        Status = "Applied",
                        Other = ""
                    },
                    new Application
                    {
                        Company = "GlobalSoft",
                        Role = "IT Consultant",
                        Date = DateTime.Parse("2024-02-27"),
                        Resume = "Tech",
                        Status = "Applied",
                        Other = ""
                    },
                    new Application
                    {
                        Company = "Future Solutions",
                        Role = "Data Scientist",
                        Date = DateTime.Parse("2024-02-26"),
                        Resume = "Tech",
                        Status = "Applied",
                        Other = ""
                    },
                    new Application
                    {
                        Company = "TechSolutions Inc.",
                        Role = "Cybersecurity Analyst",
                        Date = DateTime.Parse("2024-02-25"),
                        Resume = "Tech",
                        Status = "Applied",
                        Other = ""
                    },
                    new Application
                    {
                        Company = "DigitalTech Innovations",
                        Role = "UI/UX Designer",
                        Date = DateTime.Parse("2024-02-24"),
                        Resume = "Tech",
                        Status = "Applied",
                        Other = ""
                    },
                    new Application
                    {
                        Company = "SmartSystems Ltd.",
                        Role = "Network Administrator",
                        Date = DateTime.Parse("2024-02-23"),
                        Resume = "Tech",
                        Status = "Applied",
                        Other = ""
                    },
                    new Application
                    {
                        Company = "TechWorks Corp.",
                        Role = "Software Developer",
                        Date = DateTime.Parse("2024-02-22"),
                        Resume = "Tech",
                        Status = "Applied",
                        Other = ""
                    },
                    new Application
                    {
                        Company = "InnovateTech Solutions",
                        Role = "Data Engineer",
                        Date = DateTime.Parse("2024-02-21"),
                        Resume = "Tech",
                        Status = "Applied",
                        Other = ""
                    },
                    new Application
                    {
                        Company = "ApexTech",
                        Role = "Cloud Solutions Architect",
                        Date = DateTime.Parse("2024-02-20"),
                        Resume = "Tech",
                        Status = "Applied",
                        Other = ""
                    },
                    new Application
                    {
                        Company = "BrightTech Innovations",
                        Role = "DevOps Engineer",
                        Date = DateTime.Parse("2024-02-19"),
                        Resume = "Tech",
                        Status = "Applied",
                        Other = ""
                    },
                    new Application
                    {
                        Company = "DataSphere Technologies",
                        Role = "Business Intelligence Analyst",
                        Date = DateTime.Parse("2024-02-18"),
                        Resume = "Tech",
                        Status = "Applied",
                        Other = ""
                    },
                    new Application
                    {
                        Company = "TechMinds Inc.",
                        Role = "Machine Learning Engineer",
                        Date = DateTime.Parse("2024-02-17"),
                        Resume = "Tech",
                        Status = "Applied",
                        Other = ""
                    },
                    new Application
                    {
                        Company = "Innovative Systems Ltd.",
                        Role = "Database Administrator",
                        Date = DateTime.Parse("2024-02-16"),
                        Resume = "Tech",
                        Status = "Applied",
                        Other = ""
                    },
                    new Application
                    {
                        Company = "TechGenius Solutions",
                        Role = "Quality Assurance Analyst",
                        Date = DateTime.Parse("2024-02-15"),
                        Resume = "Tech",
                        Status = "Applied",
                        Other = ""
                    },
                    new Application
                    {
                        Company = "VisionaryTech Corp.",
                        Role = "IT Project Manager",
                        Date = DateTime.Parse("2024-02-14"),
                        Resume = "Tech",
                        Status = "Applied",
                        Other = ""
                    },
                    new Application
                    {
                        Company = "Innovative Tech Systems",
                        Role = "Network Security Engineer",
                        Date = DateTime.Parse("2024-02-13"),
                        Resume = "Tech",
                        Status = "Applied",
                        Other = ""
                    }
                );
            context.SaveChanges();
        }
    }
}
