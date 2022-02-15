using CRUDDemo.Model;

namespace CRUDDemo.EmployeeData
{
    public interface IEmployeedata
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(Guid id);
        Employee AddEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        Employee EditEmployee(Employee employee);


    }
}
