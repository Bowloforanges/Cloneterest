using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Users.DTO;
using Users.Presenters.Interfaces;
using Users.UseCasesPorts.Interfaces;

namespace Users.Controllers
{
    [ApiController]
    [Route("api/v1/Users")]
    public class DeleteUserController : ControllerBase
    {
        private readonly IDeleteUserInputPort _deleteUserInputPort;
        public DeleteUserController(IDeleteUserInputPort deleteUserInputPort) => 
            (_deleteUserInputPort) = (deleteUserInputPort);

        //DELETE /api/v1/Users/{userId} - Delete existing user
        [HttpDelete("{userId}")]
        public async Task<IActionResult> DeleteUser(string userId)
        {
            //TODO: validar dto, faktan cosas
            if (userId is null)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            await _deleteUserInputPort.Handle(new DeleteUserDTO { UserId = userId });

            //TODO: validar que se haya borrado antes de devolver eso.
            return Ok();
        }
    }
}
