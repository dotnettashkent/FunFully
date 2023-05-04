using FunFully.Service.DTOs.Users;
using FunFully.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FunFully.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;
        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        public async ValueTask<ActionResult<UserResultDto>> PostAsync(UserCreationDto dto)
            => Ok(await userService.CreateAsync(dto));
    }
}
