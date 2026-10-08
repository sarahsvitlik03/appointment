// AppointmentApp.cs
// Sarah Svitlik
// Sept. 23 2026

using System.ComponentModel.DataAnnotations;

public class Appointment
{
    public int Id { get; set; }
     
     public DateTime Time { get; set; }

    [Required]
    [StringLength(100)]
    public string ServiceType { get; set; } = "";

     // Foreign key to User
    public int UserId { get; set; }
    public User User { get; set; }  // Navigation property

}