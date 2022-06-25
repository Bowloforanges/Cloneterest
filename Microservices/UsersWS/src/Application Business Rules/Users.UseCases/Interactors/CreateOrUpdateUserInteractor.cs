using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.DTO;
using Users.UseCasesPorts.Interfaces;

namespace Users.UseCases.Interactors
{
    public class CreateOrUpdateUserInteractor : ICreateUserInputPort
    {
        private readonly ICreateUserOutputPort _createUserOutputPort;
        public CreateOrUpdateUserInteractor(ICreateUserOutputPort createUserOutputPort) => (_createUserOutputPort) = (createUserOutputPort);

        public async Task Handle(CreateOrUpdateUserDTO user)
        {
            //validar que el google id no exista para algun usuario.

            //Insertar en db, retornar id para formar URI
            await _createUserOutputPort.Handle(new GetUserDTO { UserId = "DummyID"} );
            await Task.CompletedTask;
        }
    }
}
