using System.Threading.Tasks;
using Users.DTO;

namespace Users.UseCasesPorts.Interfaces
{
    public interface IGetUserInputPort
    {
        Task Handle(GetUserDTO user);
    }
}
