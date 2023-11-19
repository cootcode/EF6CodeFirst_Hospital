using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EF6CodeFirst_Hospital.Models
{
    public class DatabaseInitializer:DropCreateDatabaseAlways<HospitalDbContext>
    {
        protected override void Seed(HospitalDbContext context)
        {

            Ward ward1 = new Ward { Name = "Surgery", BedsNo = 10, IsFull = false };
            Ward ward2 = new Ward { Name = "A&E", BedsNo = 15, IsFull = true };
            Ward ward3 = new Ward { Name = "Cardiology", BedsNo = 8, IsFull = false };
            Ward ward4 = new Ward { Name = "Respiratory", BedsNo = 10, IsFull = false };

            List<Ward> wards = new List<Ward>();
            wards.Add(ward1);
            wards.Add(ward2);
            wards.Add(ward3);
            wards.Add(ward4);

            Patient pat1 = new Patient { Name = "Joe Black", Medical = "Surgery", Treatment = "Initium mihi operis Servius Galba iterum Titus Vinius consules erunt. nam post conditam urbem octingentos" };
            Patient pat2 = new Patient { Name = "Mary Smith", Medical = "Cardiology", Treatment = "Initium mihi operis Servius Galba iterum Titus Vinius consules erunt. nam post conditam urbem octingentos" };
            Patient pat3 = new Patient { Name = "Marcus Aurelius", Medical = "General", Treatment = "Initium mihi operis Servius Galba iterum Titus Vinius consules erunt. nam post conditam urbem octingentos" };

            List<Patient> patients = new List<Patient>();
            patients.Add(pat1);
            patients.Add(pat2);
            patients.Add(pat3);

            Surgeon surg1 = new Surgeon { Name = "Livvy Green", Title = "Consultant", Grade = 4 };
            Surgeon surg2 = new Surgeon { Name = "Ross Geller", Title = "Cardiology", Grade = 2 };
            Surgeon surg3 = new Surgeon { Name = "Joe Triviani", Title = "Broken Bones", Grade = 1 };

            List<Surgeon> surgeons = new List<Surgeon>();
            surgeons.Add(surg1);
            surgeons.Add(surg2);
            surgeons.Add(surg3);

            Doctor doc1 = new Doctor { Name = "Pata Pata", Title = "Consultant", Specialism = "Dermatologist" };
            Doctor doc2 = new Doctor { Name = "Gladys Glad", Title = "Doctor", Specialism = "General" };

            List<Doctor> doctors = new List<Doctor>();
            doctors.Add(doc1);
            doctors.Add(doc2);

            Hospital hospital = new Hospital { Name = "Mary Queen", };

            hospital.Patients = patients;
            hospital.Wards = wards;
            hospital.Surgeons = surgeons;
            hospital.Doctors = doctors;

            context.Hospitals.Add(hospital);
            context.SaveChanges();

            ///////////////////
            base.Seed(context);
        }
    }
}