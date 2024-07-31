using Application.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserService userService) : CustomBaseController
    {
        [HttpPost]
        public async Task<IActionResult> Create(UserCreateRequestDto request) =>
            CreateActionResult(await userService.Create(request));
    }
}