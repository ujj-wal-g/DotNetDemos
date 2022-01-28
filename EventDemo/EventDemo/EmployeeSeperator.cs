// Publisher class
namespace EventDemo
{
    class EmployeeEventArg : EventArgs
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
    }
    class EmployeeSeperator
    {
        // public delegate void EmployeeSepratedEventHandler();
        public event EventHandler<EmployeeEventArg> EmployeeSeprated;

        public void seperate()
        {
            EmployeeEventArg empEventArg = new EmployeeEventArg { EmpID = 123, Name = "John" };
            if (EmployeeSeprated != null)
                EmployeeSeprated(this, empEventArg);
        }
    }
}
