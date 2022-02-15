﻿using CRUDDemo.Model;

namespace CRUDDemo.EmployeeData
{
    public class MockEmployeeData : IEmployeedata
    { 
        private List<Employee> employees=new List<Employee>()
        {
            new Employee()
            {
                Id = Guid.NewGuid(),
                Name ="Employee One"
            },
             new Employee()
            {
                Id = Guid.NewGuid(),
                Name ="Employee two"
            }
        };
    
        public Employee AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();
            employees.Add(employee);
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
           employees.Remove(employee); 
        }

        public Employee EditEmployee(Employee employee)
        {
            var existingEmployee = GetEmployee(employee.Id);
            existingEmployee.Name = employee.Name;
            return existingEmployee;
        }

        public Employee GetEmployee(Guid id)
        {
           return employees.SingleOrDefault(x=>x.Id== id);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
