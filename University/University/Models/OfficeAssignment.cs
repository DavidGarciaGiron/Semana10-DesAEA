using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    public class OfficeAssignment
    {
        internal int active;

        [Key]
        [ForeignKey("Instructor")]

        public int InstructorID { get; set; } 
        [StringLength(50)]
        [Display(Name = "Office Location")]
        public string location { get; set; }

        public virtual Instructor Instructor { get; set; }

    }
}