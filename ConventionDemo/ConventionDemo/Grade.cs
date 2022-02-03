using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventionDemo
{
    internal class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string GradeSection { get; set; }

        // Navigation Property
        public ICollection<Student>  students { get; set; }


    }
}
