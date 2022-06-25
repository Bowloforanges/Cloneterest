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
    public class CreateOrUpdateUserController : ControllerBase
    {
        private readonly IUpdateUserInputPort _updateUserInputPort;
        private readonly IUpdateUserOutputPort _updateUserOutputPort;
        public CreateOrUpdateUserController(IUpdateUserInputPort updateUserInputPort, IUpdateUserOutputPort updateUserOutputPort) => 
            (_updateUserInputPort, _updateUserOutputPort) = (updateUserInputPort, updateUserOutputPort);

        //PATCH /api/v1/Users/{userId} - Update existing user
        [HttpPatch("{userId}")]
        public async Task<IActionResult> UpdateUser(CreateOrUpdateUserDTO user, string userId)
        {
            //TODO: validar dto, faktan cosas
            if (userId is null)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            //Call input port to update user TODO: ver si se puede cambiar por otro DTO que tenga todo aqui
            await _updateUserInputPort.Handle(user, userId);

            //Get result from output port and generate URI
            var result = ((IPresenter<UserDTO>)_updateUserOutputPort).Content;
            var userURI = $"{HttpContext.Request.Path}/{result.UserId}";

            //TODO: validar que se haya creado antes de devolver eso. ALso revisar si con patched se regresa created.
            return Created(userURI, result);
        }
    }
}
