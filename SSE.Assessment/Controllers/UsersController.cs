using Microsoft.AspNetCore.Mvc;
using SSE.Assessment.Domain.Users.Interfaces;
using System.Net;

namespace SSE.Assessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get([FromServices] IUserService userService)
        {
            var response = await userService.Get();

            if (response.StatusCode == HttpStatusCode.OK)
                return Ok(response.Content);

            return StatusCode((int)response.StatusCode);
        }
    }
}
