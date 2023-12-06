using System.ComponentModel.DataAnnotations;

namespace DataAnnotationsSample;

public class Student
{
    [Required]
    public Guid Id { get; set; }

    [Length(1, 20)]
    [Required]
    public string FirstName { get; set; }

    [Length(1, 20)]
    [Required]
    public string LastName { get; set; }


    [Range(15, 25, MinimumIsExclusive = true, MaximumIsExclusive = true)]
    public int Age { get; set; }

    [AllowedValues("Freshman", "Sophomore", "Junior", "Senior")]
    public string Grade { get; set; }

    [DeniedValues("123456", "qwerty")]
    public string Password { get; set; }

    [Base64String]
    public string Hash { get; set; }
}
