// DbContext.cs
// Sarah Svitlik
// Oct. 8th 2026

 using Microsoft.EntityFrameworkCore;

public class AppointmentDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Appointment> Appointments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseMySql(
            //"server=localhost;database=appointmentdb;user=root;password=your_password",
            //ServerVersion.AutoDetect("server=localhost;database=appointmentdb;user=root;password=your_password")
        //);
    //}
}

}