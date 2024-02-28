using Microsoft.AspNetCore.Mvc.Rendering;

namespace JobApplicationDashboard.Models;

public class ApplicationsListViewModel
{
    public List<Application>? Applications { get; set; }
    public SelectList? Statuses { get; set; }
    public string? Status { get; set; }
    public string? SearchString { get; set; }
}
