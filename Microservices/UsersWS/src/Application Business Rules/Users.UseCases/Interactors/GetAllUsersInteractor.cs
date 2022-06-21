using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.DTO;
using Users.UseCasesPorts.Interfaces;

namespace Users.UseCases.Interactors
{
    public class GetAllUsersInteractor : IGetAllUsersInputPort
    {
        private readonly IGetAllUsersOutputPort _getAllUsersOutputPort;
        public GetAllUsersInteractor(IGetAllUsersOutputPort getAllUsersOutputPort) => (_getAllUsersOutputPort) = (getAllUsersOutputPort);
        public async Task Handle()
        {
            System.Console.WriteLine($"----- GetUserInteractor Multiple Users");

            //Hacer Query en DB
            List<UserDTO> result = new List<UserDTO>();

            result.Append(new UserDTO { UserId = "aaa" });
            result.Append(new UserDTO { UserId = "bbb" });
            result.Append(new UserDTO { UserId = "ccc" });

            //Postear en MessageQueue

            //Mappear aca los Usuarios de DB a dtos para pasarselo al outputport, en vez de un user nuevo

            await _getAllUsersOutputPort.Handle(result);
            await Task.CompletedTask;
        }
    }
}
