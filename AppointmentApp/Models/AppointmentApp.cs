// AppointmentApp.cs
// Sarah Svitlik
// Sept. 23 2026

using System.ComponentModel.DataAnnotations;

public class Appointment
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string CustomerName{ get; set; } = "";   
     
     public DateTime Time { get; set; }

    [Required]
    [StringLength(100)]
    public string ServiceType { get; set; } = "";
}