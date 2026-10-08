// AppointmentDbContext.cs
// Sarah Svitlik
// Oct. 8th 2026

using Microsoft.EntityFrameworkCore;
using AppointmentApp.Models;

public class AppointmentDbContext : DbContext
{
    public AppointmentDbContext(DbContextOptions<AppointmentDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
}
