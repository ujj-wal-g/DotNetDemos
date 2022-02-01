using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPIDemo2
{
    internal class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProgramLanguage { get; set; }
        public string Database { get; set; }
         
        // Navigation Property
        public virtual ICollection<Employee> Employees { get; set;}
        
    }
}
