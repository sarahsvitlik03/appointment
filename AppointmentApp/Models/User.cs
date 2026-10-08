// User.cs
// Sarah Svitlik
// Oct. 8th 2026

using System.ComponentModel.DataAnnotations;

public class User
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = "";   

    [Required]
    [StringLength(100)]
     public string Email { get; set; } = "";   

    // User's Appointments
    public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

}