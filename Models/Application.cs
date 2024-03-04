using System.ComponentModel.DataAnnotations;

namespace JobApplicationDashboard.Models;

public class Application
{
    public int Id { get; set; }

    [Required]
    [StringLength(70, MinimumLength = 1)]
    public string? Company { get; set; }

    [Required]
    [StringLength(255, MinimumLength = 2)]
    public string? Role { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime Date { get; set; }

    [Required]
    [StringLength(255, MinimumLength = 3)]
    public string? Resume { get; set; }

    [Required]
    public string? Status { get; set; }

    [StringLength(1024)]
    public string? Other { get; set; }
}
