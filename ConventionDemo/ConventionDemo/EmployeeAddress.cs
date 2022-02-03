using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventionDemo
{
     class EmployeeAddress
    {
        [ForeignKey("Employee")]
        [Key]
        public int EmpAddressId { get; set; }
        public string EmpAddress { get; set; }
        public string EmpCity { get; set; }
        public int EmpPinCode { get; set; }
        public string EmpState { get; set; }
        // Navigation Property
        public virtual Employee Employee { get; set; }
    }
}
