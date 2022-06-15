using System.Threading.Tasks;

namespace Users.UseCasesPorts.Interfaces
{
    public interface IGetUserOutputPort
    {
        public Task Handle();
    }
}
