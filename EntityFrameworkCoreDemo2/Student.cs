using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreDemo2
{
    internal class Student
    {
        
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime DateOfBirth { get; set; }= DateTime.Now;
        public float Height { get; set; }
       public float Weight { get; set; }
        public string Department { get; set; }
    }
}
