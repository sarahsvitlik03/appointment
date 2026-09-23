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

    [HttpPost]
    public IActionResult Create(Appointment appt)
    {
        appt.Id = appointments.Count + 1;
        appointments.Add(appt);
        return Ok(appt);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var appt = appointments.FirstOrDefault(a => a.Id == id);
        if (appt == null) return NotFound();
        appointments.Remove(appt);
        return Ok();
    }
}
