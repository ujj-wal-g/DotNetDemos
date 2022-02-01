using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPIDemo2
{
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeId { get; set; }
        public string EmpName { get; set; }
        public string Email { get; set; }
        public int PrimaryContact { get; set; }

        //Navigation Property
        public virtual Department Department { get; set; }
        public virtual EmployeeAddress EmployeeAddress { get; set; }
        public virtual Team Team { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
