using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EmployeeJWTAPI.Models;

namespace EmployeeJWTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>()
        {
            new Employee
            {
                Id = 1,
                Name = "John",
                Department = "IT",
                Salary = 50000
            },

            new Employee
            {
                Id = 2,
                Name = "David",
                Department = "HR",
                Salary = 45000
            },

            new Employee
            {
                Id = 3,
                Name = "Smith",
                Department = "Finance",
                Salary = 60000
            }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetEmployees()
        {
            return Ok(employees);
        }
    }
}