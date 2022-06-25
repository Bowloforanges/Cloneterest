using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Users.DTO;
using Users.Presenters.Interfaces;
using Users.UseCasesPorts.Interfaces;

namespace Users.Controllers
{
    [Route("api/v1/Users")]
    [ApiController]
    public class GetUserController : ControllerBase
    {
        private readonly IGetUserInputPort _getUserInputPort;
        private readonly IGetUserOutputPort _getUserOutputPort;

        private readonly IGetAllUsersInputPort _getAllUsersInputPort;
        private readonly IGetAllUsersOutputPort _getAllUsersOutputPort;

        public GetUserController(IGetUserInputPort getUserInputPort, IGetUserOutputPort getUserOutputPort, IGetAllUsersInputPort getAllUsersInputPort, IGetAllUsersOutputPort getAllUsersOutputPort) => 
            (_getUserInputPort, _getUserOutputPort, _getAllUsersInputPort, _getAllUsersOutputPort) = (getUserInputPort, getUserOutputPort, getAllUsersInputPort, getAllUsersOutputPort);

        //GET /api/v1/Users/{userId} - Get existing user
        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUser(string userId)
        {
            if (userId is null)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            await _getUserInputPort.Handle(new GetUserDTO { UserId = userId });
            
            var result = ((IPresenter<UserDTO>)_getUserOutputPort).Content;

            return result == null ? NoContent() : Ok(result);
        }

        //DELETE /api/v1/Users - Get all existing users (TODO: revisar paginacion)
        [HttpGet()]
        public async Task<IActionResult> GetAllUsers()
        {
            await _getAllUsersInputPort.Handle();

            var result = ((IPresenter<IEnumerable<UserDTO>>)_getAllUsersOutputPort).Content;

            return result == null ? NoContent() : Ok(result);
        }
    }
}
