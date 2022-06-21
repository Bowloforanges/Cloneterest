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
            System.Console.WriteLine($"----- GetUserInteractor Single User - {user.UserId}");
            //Validar user
            //Hacer Query en DB
            //Postear en MessageQueue

            //Mappear aca el Usuario de DB a un dto para pasarselo al outputport, en vez de un user nuevo
            await _getUserOutputPort.Handle(new UserDTO { UserId = "aaa", });
            await Task.CompletedTask;
        }
    }
}
