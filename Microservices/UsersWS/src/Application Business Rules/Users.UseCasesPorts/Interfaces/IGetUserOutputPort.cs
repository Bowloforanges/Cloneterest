using System.Threading.Tasks;
using Users.DTO;

namespace Users.UseCasesPorts.Interfaces
{
    public interface IGetUserOutputPort
    {
        public Task Handle(UserDTO user);
    }
}
