using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventionDemo
{
    internal class Student
    {
        [Key]
        public int sId { get; set; }
        public string sName { get; set; }
        public int currentGradeId { get; set; }


        // Navigation Property
        public Grade Grade { get; set; }
    }
}
