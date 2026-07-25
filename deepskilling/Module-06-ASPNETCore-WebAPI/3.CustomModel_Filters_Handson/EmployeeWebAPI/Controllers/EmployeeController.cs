using Microsoft.AspNetCore.Mvc;
using EmployeeWebAPI.Models;
using EmployeeWebAPI.Filters;

namespace EmployeeWebAPI.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  [ServiceFilter(typeof(CustomAuthFilter))]
    public class EmployeeController : ControllerBase
    {
        private List<Employee> employees;

        public EmployeeController()
        {
            employees = GetStandardEmployeeList();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(employees);
        }

        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            employees.Add(employee);
            return Ok(employees);
        }

        [HttpPut]
        public IActionResult Put(Employee employee)
        {
            var emp = employees.FirstOrDefault(e => e.Id == employee.Id);

            if (emp != null)
            {
                emp.Name = employee.Name;
                emp.Salary = employee.Salary;
                emp.Permanent = employee.Permanent;
                emp.Department = employee.Department;
                emp.Skills = employee.Skills;
                emp.DateOfBirth = employee.DateOfBirth;
            }

            return Ok(employees);
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>()
            {
                new Employee
                {
                    Id = 1,
                    Name = "John",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department
                    {
                        Id = 1,
                        Name = "IT"
                    },
                    Skills = new List<Skill>
                    {
                        new Skill{ Id=1, Name="C#" },
                        new Skill{ Id=2, Name=".NET"}
                    },
                    DateOfBirth = new DateTime(1998,5,20)
                },

                new Employee
                {
                    Id = 2,
                    Name = "Alice",
                    Salary = 65000,
                    Permanent = true,
                    Department = new Department
                    {
                        Id = 2,
                        Name = "HR"
                    },
                    Skills = new List<Skill>
                    {
                        new Skill{ Id=3, Name="Communication"}
                    },
                    DateOfBirth = new DateTime(1997,8,15)
                }
            };
        }
    }
}