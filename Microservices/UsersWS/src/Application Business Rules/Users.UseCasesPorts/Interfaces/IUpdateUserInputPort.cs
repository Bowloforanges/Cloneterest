using System.Threading.Tasks;
using Users.DTO;

namespace Users.UseCasesPorts.Interfaces
{
    public interface IUpdateUserInputPort
    {
        public Task Handle(CreateOrUpdateUserDTO user, string userId);
    }
}