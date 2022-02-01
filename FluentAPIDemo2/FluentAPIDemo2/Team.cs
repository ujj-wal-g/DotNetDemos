using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPIDemo2
{
    internal class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public int TeamSize { get; set; }

        // Navigation Property
        public virtual ICollection<Employee> Employees { get; set;}
    }
}
