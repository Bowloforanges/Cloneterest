using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.DTO;
using Users.UseCasesPorts.Interfaces;

namespace Users.UseCases.Interactors
{
    public class UpdateUserInteractor : IUpdateUserInputPort
    {
        private readonly IUpdateUserOutputPort _updateUserOutputPort;

        public UpdateUserInteractor(IUpdateUserOutputPort updateUserOutputPort) => (_updateUserOutputPort) = (updateUserOutputPort);

        public async Task Handle(CreateOrUpdateUserDTO user, string userId)
        {
            //TODO: Validar DTO

            //TODO: Revisar si id existe en DB, si no retornar error.
            //TODO: hacer update del usuario
            
            await _updateUserOutputPort.Handle( new UserDTO { UserId = userId, Name = "UpdatedFakeName", Surname = user.Surname, Email = "UpdatedFakeEmalil", GoogleId = user.GoogleId });
            await Task.CompletedTask;
        }
    }
}
