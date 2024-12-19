using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quiz.WebApi.Services;

namespace Quiz.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices userServices;

        public UserController(IUserServices userServices)
        { 
             this.userServices = userServices;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetUser()
        {
            return BadRequest();
        } 
    }
}
