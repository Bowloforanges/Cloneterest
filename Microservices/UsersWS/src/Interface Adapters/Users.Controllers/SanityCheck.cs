using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Users.Controllers
{
    [ApiController]
    [Route("api/v1/Users/Sanity")]
    public class SanityCheckController : ControllerBase
    {
        //GET /api/v1/Users/SanityCheck - Service Status
        [HttpGet]
        public async Task<IActionResult> Check()
        {
            return Ok("Alles Gut.");
        }
    }
}