using Microsoft.AspNetCore.Mvc;
using TheHMS.IService.IService.Auth;

namespace TheHMS.ApiService.Controller.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthControllerTests : ControllerBase
    {
        private readonly IAuth _authService;
        public AuthControllerTests(IAuth auth)
        {
            _authService = auth;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] dynamic loginData)
        {
            if (loginData == null || string.IsNullOrEmpty(loginData.username) || string.IsNullOrEmpty(loginData.password))
            {
                return BadRequest("Username and password are required.");
            }

            var response = await _authService.Login(loginData.username.ToString(), loginData.password.ToString());
            if (response.success)
            {
                return Ok(response);
            }
            else
            {
                return Unauthorized(response);
            }
        }


    }
}
