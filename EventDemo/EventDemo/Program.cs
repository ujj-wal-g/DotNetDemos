using System;
namespace EventDemo;
class Program
{
    //Hooks for Publisher and Subscriber
    static void Main(string[] args)
    {
        EmployeeSeperator employeeSeperator = new EmployeeSeperator();
        
        
        Finance fi = new Finance(employeeSeperator);
        IT it = new IT(employeeSeperator);
        employeeSeperator.seperate();
        Console.ReadKey();
    }

}
