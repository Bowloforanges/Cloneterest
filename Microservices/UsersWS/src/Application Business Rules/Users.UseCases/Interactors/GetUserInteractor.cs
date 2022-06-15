using System.Threading.Tasks;
using Users.DTO;
using Users.UseCasesPorts.Interfaces;

namespace Users.UseCases.Interactors
{
    public class GetUserInteractor : IGetUserInputPort
    {

        private readonly IGetUserOutputPort _getUserOutputPort;
        public GetUserInteractor(IGetUserOutputPort getUserOutputPort) => 
            (_getUserOutputPort) = (getUserOutputPort);

        public async Task Handle(GetUserDTO user)
        {
            System.Console.WriteLine($"----- GetUserInteractor - {user.UserId}");

            await _getUserOutputPort.Handle();
            await Task.CompletedTask;
        }
    }
}
