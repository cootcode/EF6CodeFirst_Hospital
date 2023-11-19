using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EF6CodeFirst_Hospital.Models
{
    public class HospitalDbContext:DbContext
    {

        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Surgeon> Surgeons { get; set; }

        public HospitalDbContext():base("HospitalConnection")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }
    }
}