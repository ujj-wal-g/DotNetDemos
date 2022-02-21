using DependecyInjectionDemo.EmployeeData;
using DependecyInjectionDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependecyInjectionDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _employee;
        public EmployeeController(IEmployee employee)
        {
            _employee = employee;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_employee.GetAllEmployees());
        }
        [HttpGet("id")]
        public IActionResult Get(Guid id)
        {  
         var employee= _employee.GetEmployee(id);
            if(employee == null)
            {
                return NotFound("Not Found ");
            }
            return Ok(employee);
           
        }
        [HttpPost]
        public IActionResult Post(Employee emp)
        {
             _employee.AddEmployee(emp);
            return Created(HttpContext.Request.Scheme+"://"+HttpContext.Request.Host+HttpContext.Request.Path+"/"+emp.Id,emp);

        }
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
           var EmpExist = _employee.GetEmployee(id);
            if(EmpExist==null)
            {
                 NotFound($"Employee with id{id} is not found in database");
            }
           _employee.DeleteEmployee(EmpExist);
          
        }
        [HttpPatch]
        public IActionResult Edit(Employee emp,Guid id)
        {
            var ExistingEmp = _employee.GetEmployee(id);
            if(ExistingEmp!=null)
            {
                emp.Id = ExistingEmp.Id;
                _employee.UpdateEmployee(emp);
               
            }
            return Ok(emp);

        }
    }
}
