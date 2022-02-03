using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventionDemo
{
    class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        // Navigation Property
        public virtual EmployeeAddress Address { get; set; }
    }
    
}
