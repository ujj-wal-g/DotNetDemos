using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class IT
    {
        private readonly EmployeeSeperator employeeSeperator;

        public IT(EmployeeSeperator employeeSeperator)
        {
            this.employeeSeperator = employeeSeperator;
            employeeSeperator.EmployeeSeprated += EmployeeSepratedEventHandler;

             
        }
        public void EmployeeSepratedEventHandler(object? sender, EmployeeEventArg e)
        {
            Console.WriteLine("IT department:"+e.Name);
        }
    }
}
