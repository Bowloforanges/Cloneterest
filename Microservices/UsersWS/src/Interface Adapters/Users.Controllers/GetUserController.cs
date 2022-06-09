using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Users.DTO;
using Users.UseCasesPorts.Interfaces;

namespace Users.Controllers
{
    [Route("api/v1/Users")]
    [ApiController]
    public class GetUserController : ControllerBase
    {
        private readonly IGenericInputPort<BaseDTO> _getUserInputPort;
        public GetUserController(IGenericInputPort<BaseDTO> getUserInputPort) => (_getUserInputPort) = (getUserInputPort);

        [HttpGet]
        public async Task<IActionResult> GetUser(GetUserDTO user) 
        {
            await _getUserInputPort.Handle(user);
            return Ok();
        }
    }
}
