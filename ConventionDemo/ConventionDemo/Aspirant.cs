using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventionDemo
{
     class Aspirant
    {
        [Key]
        public int AspId { get; set; }
        public string AspName { get; set; }
        public IList<AspirantCourse> AspirantCourses { get; set; }

    }
}
