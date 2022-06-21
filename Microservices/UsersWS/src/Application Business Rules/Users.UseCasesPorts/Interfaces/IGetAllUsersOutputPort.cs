using System.Collections.Generic;
using System.Threading.Tasks;
using Users.DTO;

namespace Users.UseCasesPorts.Interfaces
{
    public interface IGetAllUsersOutputPort
    {
        public Task Handle(IEnumerable<UserDTO> users);
    }
}
