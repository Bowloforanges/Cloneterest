using System.Threading.Tasks;
using Users.DTO;
using Users.Presenters.Interfaces;
using Users.UseCasesPorts.Interfaces;

namespace Users.Presenters.Presenters
{
    public class UpdateUserPresenter : IUpdateUserOutputPort, IPresenter<UserDTO>
    {
        public UserDTO Content { get; private set; }

        public UpdateUserPresenter()
        {

        }

        public async Task Handle(UserDTO user)
        {
            Content = user;
            await Task.CompletedTask;
        }
    }
}
