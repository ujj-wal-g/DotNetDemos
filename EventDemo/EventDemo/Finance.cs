using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//subscriber class
namespace EventDemo
{
    internal class Finance
    {
        private readonly EmployeeSeperator employeeSeperator;
        public Finance(EmployeeSeperator employeeSeperator)
        {
            this.employeeSeperator = employeeSeperator;
            employeeSeperator.EmployeeSeprated += EmployeeSepratedEventHandler;
        }
      public void EmployeeSepratedEventHandler(object? sender, EmployeeEventArg e)
        {
            Console.WriteLine("Finance department:"+e.Name);
        }
    }
}
