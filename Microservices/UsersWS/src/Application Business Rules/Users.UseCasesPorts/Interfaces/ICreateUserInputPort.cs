using System.Threading.Tasks;
using Users.DTO;

namespace Users.UseCasesPorts.Interfaces
{
    public interface ICreateUserInputPort
    {
        public Task Handle(CreateOrUpdateUserDTO user);
    }
}
