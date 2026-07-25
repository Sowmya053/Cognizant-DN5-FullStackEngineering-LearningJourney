using Microsoft.AspNetCore.Mvc;
using EmployeeWebAPI.Models;

namespace EmployeeWebAPI.Controllers
{

[Route("api/[controller]")]
[ApiController]

public class EmployeeController : ControllerBase
{


private static List<Employee> employees = new List<Employee>()
{

new Employee
{
Id=1,
Name="John",
Department="IT",
Salary=50000
},

new Employee
{
Id=2,
Name="David",
Department="HR",
Salary=45000
},

new Employee
{
Id=3,
Name="Smith",
Department="Finance",
Salary=60000
}

};



[HttpPut("{id}")]

public ActionResult<Employee> UpdateEmployee(int id, Employee employee)
{

if(id <= 0)
{
return BadRequest("Invalid employee id");
}


var existingEmployee = employees.FirstOrDefault(e=>e.Id==id);


if(existingEmployee == null)
{
return BadRequest("Invalid employee id");
}



existingEmployee.Name = employee.Name;

existingEmployee.Department = employee.Department;

existingEmployee.Salary = employee.Salary;



return Ok(existingEmployee);

}


}

}