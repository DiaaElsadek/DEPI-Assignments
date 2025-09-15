using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

#region Entities

public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }

    public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}

public class Doctor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Specialization { get; set; }

    public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}

public class Appointment
{
    public int PatientId { get; set; }
    public Patient Patient { get; set; }

    public int DoctorId { get; set; }
    public Doctor Doctor { get; set; }

    public DateTime AppointmentDate { get; set; }
}

#endregion

#region DbContext

public class HealthCareContext : DbContext
{
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Appointment> Appointments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseInMemoryDatabase("HealthCareDB");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Composite key for Appointment
        modelBuilder.Entity<Appointment>()
            .HasKey(a => new { a.PatientId, a.DoctorId, a.AppointmentDate });

        base.OnModelCreating(modelBuilder);
    }
}

#endregion

#region Program

internal class Program
{
    static void Main(string[] args)
    {
        using var context = new HealthCareContext();

        // Sample data
        var patient = new Patient { Name = "Ali Ahmed", DateOfBirth = new DateTime(1995, 5, 12) };
        var doctor = new Doctor { Name = "Dr. Mona", Specialization = "Cardiology" };

        var appointment = new Appointment
        {
            Patient = patient,
            Doctor = doctor,
            AppointmentDate = DateTime.Now.AddDays(1)
        };

        context.Add(appointment);
        context.SaveChanges();

        // Query appointments
        var appointments = context.Appointments
                                  .Include(a => a.Patient)
                                  .Include(a => a.Doctor)
                                  .ToList();

        foreach (var appt in appointments)
        {
            Console.WriteLine($"{appt.Patient.Name} has an appointment with {appt.Doctor.Name} ({appt.Doctor.Specialization}) on {appt.AppointmentDate}");
        }
    }
}

#endregion
