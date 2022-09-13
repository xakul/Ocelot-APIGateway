using Microsoft.AspNetCore.Mvc;

namespace User.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "User response";
        }

        [HttpGet("{id}")]
        public int Get(int id)
        {
            var returnValue = id;

            return returnValue;
        }
    }
}
