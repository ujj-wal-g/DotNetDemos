using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPIDemo2
{
    internal class EmployeeAddress
    {
        public int EmployeeId { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public int PinCode { get; set; }

        //Navigation Property
        public virtual Employee Employee { get; set; }

    }
}
