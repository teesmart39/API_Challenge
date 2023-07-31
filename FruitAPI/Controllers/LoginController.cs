using FruitAPI.JWTService;
using FruitAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FruitAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IAuth _auth;

        public LoginController(IAuth auth)
        {
            _auth = auth;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] Login loginModel)
        {
            var response = await _auth.LoginAsync(loginModel);

            if (response.StatusCode == "Success")
            {
                return Ok(response);
            }
            else if (response.StatusCode == "Error")
            {
                return Unauthorized(response);
            }

            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}
