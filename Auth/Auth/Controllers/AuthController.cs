using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        [HttpPost("registration")]
        public async Task<IActionResult> Registration()
        {
            return Ok("Hello");
        }
    }

}
