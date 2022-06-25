using System.Threading.Tasks;
using Users.DTO;

namespace Users.UseCasesPorts.Interfaces
{
    public interface ICreateUserOutputPort
    {
        public Task Handle(GetUserDTO user);
    }
}
