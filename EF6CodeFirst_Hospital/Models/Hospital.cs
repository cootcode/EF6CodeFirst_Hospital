using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EF6CodeFirst_Hospital.Models
{
    public class Hospital
    {

        [Key]
        public int HospitalId { get; set; }
        public string Name { get; set; }

        //NAVIGATIONAL PROPERTIES
        public virtual List<Ward> Wards { get; set; }
        public virtual List<Patient> Patients { get; set; }
        public virtual List<Surgeon> Surgeons { get; set; }
        public virtual List<Doctor> Doctors { get; set; }
    }
}