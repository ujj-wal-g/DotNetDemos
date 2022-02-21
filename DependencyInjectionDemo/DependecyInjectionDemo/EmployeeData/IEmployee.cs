using DependecyInjectionDemo.Models;

namespace DependecyInjectionDemo.EmployeeData
{
    public interface IEmployee
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployee(Guid id);
        Employee AddEmployee (Employee employee);
        void DeleteEmployee(Employee employee);
        Employee UpdateEmployee (Employee employee);

    }
}
