using Microsoft.AspNetCore.Mvc;

namespace RetailStoreSwaggerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<string> employees = new List<string>
        {
            "John",
            "David",
            "Alice",
            "Robert"
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(employees);
        }

        [HttpPost]
        public IActionResult Post(string name)
        {
            employees.Add(name);
            return Ok(employees);
        }
    }
}