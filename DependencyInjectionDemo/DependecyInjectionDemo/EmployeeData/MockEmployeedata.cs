using DependecyInjectionDemo.Models;

namespace DependecyInjectionDemo.EmployeeData
{
    public class MockEmployeedata : IEmployee
    {
        private List<Employee> employees = new List<Employee>()
        {
          new Employee()
          {
              Id = Guid.NewGuid(),
              Name ="Ujjwal"
          },
          new Employee()
          {
              Id = Guid.NewGuid(),
              Name ="Shivam"
          },
          new Employee()
          {
              Id = Guid.NewGuid(),
              Name ="Rohan"
          }

        };

        public List<Employee> GetAllEmployees()
        { 
        return employees;
        }

        public Employee AddEmployee(Employee employee)
        {
           employee.Id = Guid.NewGuid();
            employees.Add(employee);
            return employee;
            
        }

        public void DeleteEmployee(Employee emp)
        {
             employees.Remove(emp);
        }

        public Employee GetEmployee(Guid id)
        {
           var emp = employees.Find(x => x.Id == id);
           
            return emp;
        }

        public Employee UpdateEmployee(Employee employee)
        {
           var existingEmp = GetEmployee(employee.Id);
           existingEmp.Name = employee.Name;
            return existingEmp;
        }
    }
}
