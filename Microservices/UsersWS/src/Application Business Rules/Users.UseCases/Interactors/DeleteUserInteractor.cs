using System.Threading.Tasks;
using Users.DTO;
using Users.UseCasesPorts.Interfaces;

namespace Users.UseCases.Interactors
{
    public class DeleteUserInteractor : IDeleteUserInputPort
    {
        public async Task Handle(DeleteUserDTO userId)
        {
            //TODO: revisar que exista en db, si no retornar error

            //TODO: borrado en db
            
            await Task.CompletedTask;
        }
    }
}
