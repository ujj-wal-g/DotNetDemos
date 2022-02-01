using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPIDemo2
{
    internal class Department
    {
        
        public int DeptId { get; set; }
        public string DeptName { get; set; }

        // Navigation Property
        public virtual ICollection<Employee> employees { get; set; }
    }
}
