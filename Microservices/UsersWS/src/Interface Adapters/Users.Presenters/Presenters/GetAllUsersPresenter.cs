using System.Collections.Generic;
using System.Threading.Tasks;
using Users.DTO;
using Users.Presenters.Interfaces;
using Users.UseCasesPorts.Interfaces;

namespace Users.Presenters.Presenters
{
    public class GetAllUsersPresenter : IGetAllUsersOutputPort, IPresenter<IEnumerable<UserDTO>>
    {
        public IEnumerable<UserDTO> Content { get; private set; }

        public Task Handle(IEnumerable<UserDTO> users)
        {
            Content = users;
            return Task.CompletedTask;
        }
    }
}
