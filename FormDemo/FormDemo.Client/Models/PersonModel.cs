using System.ComponentModel.DataAnnotations;

namespace FormDemo.Client.Models;

public class PersonModel
{
    [Required]
    [MinLength(5, ErrorMessage = "First name not long enough")]
    public string? FirstName { get; set; }

    [Required(ErrorMessage = "Last name is required")]
    [MinLength(8, ErrorMessage = "Last name must be at least 8 characters long")]
    public string? LastName { get; set; }

    public string? LifeStory { get; set; }

    public bool IsAlive { get; set; }

}
