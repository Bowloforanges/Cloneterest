using System.Threading.Tasks;
using Users.DTO;

namespace Users.UseCasesPorts.Interfaces
{
    public interface IUpdateUserOutputPort
    {
        public Task Handle(UserDTO user);
    }
}
