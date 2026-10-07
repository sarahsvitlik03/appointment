// AppointmentController.cs
// Sarah Svitlik
// Sept. 23 2026

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class AppointmentController : ControllerBase
{
    private static List<Appointment> appointments = new List<Appointment>();

    [HttpGet]
    public IEnumerable<Appointment> Get() => appointments;

    // Create Appointment
    [HttpPost]
    public IActionResult Create(Appointment appt)
    {
        appt.Id = appointments.Count + 1;
        appointments.Add(appt);
        return Ok(appt);
    }

    // Delete Appointment
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var appt = appointments.FirstOrDefault(a => a.Id == id);
        if (appt == null) return NotFound();
        appointments.Remove(appt);
        return Ok();
    }

     [HttpPut("{id}")]
    public IActionResult UpdateAppointment(int id, [FromBody] Appointment updatedAppointment)
    {
        if (updatedAppointment == null)
        {
            return BadRequest("Appointment data is required");
        }

        if (id != updatedAppointment.Id)
        {
            return BadRequest("ID mismatch");
        }
        
        // Finds the first appointment that matches the one to update
        var existingAppointment = appointments.FirstOrDefault(a => a.Id == id); 
        if (existingAppointment == null)
        {
            return NotFound($"Appointment with ID {id} not found");
        }

        // Update existing appointment with new data
        existingAppointment.CustomerName = updatedAppointment.CustomerName;
        existingAppointment.Time = updatedAppointment.Time;
        existingAppointment.ServiceType = updatedAppointment.ServiceType;
       // _database.SaveChanges();

        // 4. Return 204 NoContent for a successful complete update
        return NoContent(); 
    }

    // Add validation

     

    // Add error handling
}
