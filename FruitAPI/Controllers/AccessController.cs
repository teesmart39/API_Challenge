using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FruitAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin,BackOffice")]

    public class AccessController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            string[] fruits = new string[] { "Apple", "Banana", "Orange" };
            return Ok(fruits);
        }

    }
}
