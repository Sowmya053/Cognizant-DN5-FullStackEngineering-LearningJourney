using Microsoft.AspNetCore.Mvc;

namespace RetailStoreSwaggerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new string[]
            {
                "Apple",
                "Laptop",
                "Rice Bag"
            });
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Product Added Successfully");
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok("Product Updated Successfully");
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok("Product Deleted Successfully");
        }
    }
}