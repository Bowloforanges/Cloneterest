using System;
using System.Threading.Tasks;
using Users.DTO;
using Users.Presenters.Interfaces;
using Users.UseCasesPorts.Interfaces;

namespace Users.Presenters.Presenters
{
    public class GetUserPresenter : IGetUserOutputPort, IPresenter<UserDTO>
    {
        public UserDTO Content { get; private set; }

        public Task Handle(UserDTO user)
        {
            Content = user;
            return Task.CompletedTask;
        }
    }
}
