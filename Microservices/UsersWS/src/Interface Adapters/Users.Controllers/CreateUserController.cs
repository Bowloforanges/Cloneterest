using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Users.DTO;
using Users.Presenters.Interfaces;
using Users.UseCasesPorts.Interfaces;

namespace Users.Controllers
{
    [ApiController]
    [Route("api/v1/Users")]
    public class CreateUserController : ControllerBase
    {
        private readonly ICreateUserInputPort _createUserInputPort;
        private readonly ICreateUserOutputPort _createUserOutputPort;
        public CreateUserController(ICreateUserInputPort createUserInputPort, ICreateUserOutputPort createUserOutputPort) => 
            (_createUserInputPort, _createUserOutputPort) = (createUserInputPort, createUserOutputPort);

        //POST /api/v1/Users - Create new user
        [HttpPost()]
        public async Task<IActionResult> CreateUser(CreateOrUpdateUserDTO user)
        {
            //TODO: validar dto

            //Call input port to insert new user
            await _createUserInputPort.Handle(user);

            //Get result from output port and generate URI
            var result = ((IPresenter<GetUserDTO>)_createUserOutputPort).Content;
            var userURI = $"{HttpContext.Request.Path}/{result.UserId}";

            //TODO: validar que se haya creado antes de devolver eso.
            return Created(userURI, result);
        }
    }
}
