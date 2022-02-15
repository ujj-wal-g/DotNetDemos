using CRUDDemo.EmployeeData;
using CRUDDemo.Model;
using Microsoft.AspNetCore.Mvc;

namespace CRUDDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private IEmployeedata _employeeData;
        public EmployeeController(IEmployeedata employeedata)
        {
            _employeeData = employeedata;
        }
        [HttpGet]

        public IActionResult GetEmployee()
        {
            return Ok(_employeeData.GetEmployees());
        }
        [HttpGet("{id}")]

        public IActionResult GetEmployee(Guid id)
        {
            var employee = _employeeData.GetEmployee(id);
            if (employee != null)
            {
                return Ok(employee);
            }
            return NotFound($"Employee with id:{id} was not found");
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            _employeeData.AddEmployee(employee);
            return Created(HttpContext.Request.Scheme + "//:" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + employee.Id, employee);


        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(Guid id)
        {
            var employee = _employeeData.GetEmployee(id);
           if(employee != null)
            {
                _employeeData.DeleteEmployee(employee);
                return Ok();
            }
           return NotFound($"Employee with id:{id} was not found");


        }
        [HttpPatch("{id}")]
        public IActionResult EditEmployee(Guid id,Employee employee)
        {
            var Existingemployee = _employeeData.GetEmployee(id);
            if (Existingemployee != null)
            {
                employee.Id = Existingemployee.Id;
                _employeeData.EditEmployee(employee);
            }
            return Ok(employee);


        }
    }
}
