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

    public DateTime? BirthDate { get; set; } = DateTime.Now;
    
    [Range(typeof(DateOnly), "1/1/1980", "12/31/2025", ErrorMessage = "Birth date only is out of range")]
    public DateOnly? BirthDateOnly { get; set; } = DateOnly.FromDateTime(DateTime.Now);

    [Range(1, 120, ErrorMessage = "Age must be between 1 and 120")]
    public int Age { get; set; }

    [Range(0, 100, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
    public double Amount { get; set; }

    public string? Departnment { get; set; }

    public string? Gender { get; set; }


    public EmploymentType TypeofEmployment { get; set; }    

}

public enum EmploymentType
{
    FullTime,
    PartTime,
    Contractor
}
