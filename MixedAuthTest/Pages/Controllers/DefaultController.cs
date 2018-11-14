using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MixedAuthTest.Pages.Controllers
{    
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : Controller
    {        
        [HttpGet]
        public IActionResult Get()
        {
            return NoContent();
        }
    }
}