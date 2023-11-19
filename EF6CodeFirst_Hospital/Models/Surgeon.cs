using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EF6CodeFirst_Hospital.Models
{
    public class Surgeon
    {
        [Key]
        public int SurgeonId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int Grade { get; set; }

        //NAVIGATIONAL PROPERTIES
        [ForeignKey("Hospital")]
        public int HospitalId { get; set; }
        public Hospital Hospital { get; set; }
    }
}