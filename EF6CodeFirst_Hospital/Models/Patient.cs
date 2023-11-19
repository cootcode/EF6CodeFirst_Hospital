using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EF6CodeFirst_Hospital.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string Medical { get; set; }
        public string Treatment { get; set; }

        //NAVIGATIONAL PROPERTIES
        public virtual List<Hospital> Hospitals { get; set; }
    }
}