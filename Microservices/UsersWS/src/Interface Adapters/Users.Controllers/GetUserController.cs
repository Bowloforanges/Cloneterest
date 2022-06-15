using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Users.DTO;
using Users.UseCasesPorts.Interfaces;

namespace Users.Controllers
{
    [Route("api/v1/Users")]
    [ApiController]
    public class GetUserController : ControllerBase
    {
        private readonly IGetUserInputPort _getUserInputPort;
        public GetUserController(IGetUserInputPort getUserInputPort) => (_getUserInputPort) = (getUserInputPort);

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUser(string userId)
        {
            if (userId is null)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            await _getUserInputPort.Handle(new GetUserDTO { UserId = userId });
            return Ok();
        }
    }
}
