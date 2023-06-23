using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moazeb.BLL.DTOs.User;
using Moazeb.BLL.IService;

namespace Moazeb.Api.Controllers
{
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("api/login")]
        public async Task<IActionResult> Login([FromBody] LoginDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _userService
        }
    }
}
