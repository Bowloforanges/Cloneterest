using System.Threading.Tasks;
using Users.DTO;

namespace Users.UseCasesPorts.Interfaces
{
    public interface IGetUserInputPort
    {
        public Task Handle(GetUserDTO user);
    }
}
