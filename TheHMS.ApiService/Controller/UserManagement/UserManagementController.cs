using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;
using TheHMS.IService.IService.UserManagement;
using TheHMS.Model.Model.UserManagement;

namespace TheHMS.ApiService.Controller.UserManagement
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserManagementController : ControllerBase
    {
        private readonly IUserManagement _userManagementService;

        public UserManagementController(IUserManagement userManagement)
        {
            _userManagementService = userManagement;
        }

        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser([FromBody] UserManagementDTO user)
        {

            var response = await _userManagementService.CreateUser(user);
            return Ok(response);
        }
        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var response = await _userManagementService.GetAllUsers();
            return Ok(response);
        }
    }
}
