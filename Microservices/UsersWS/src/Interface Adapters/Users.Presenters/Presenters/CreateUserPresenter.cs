using Users.UseCasesPorts.Interfaces;
using Users.DTO;
using Users.Presenters.Interfaces;
using System.Threading.Tasks;

namespace Users.Presenters.Presenters
{
    public class CreateUserPresenter : ICreateUserOutputPort, IPresenter<GetUserDTO>
    {
        public GetUserDTO Content { get; private set; }

        public CreateUserPresenter()
        {

        }

        public async Task Handle(GetUserDTO user)
        {
            Content = user;
            await Task.CompletedTask;
        }
    }
}
