using System.Threading.Tasks;

namespace Users.UseCasesPorts.Interfaces
{
    public interface IGetAllUsersInputPort
    {
        public Task Handle();
    }
}
