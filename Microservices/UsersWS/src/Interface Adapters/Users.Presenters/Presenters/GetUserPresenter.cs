using System;
using System.Threading.Tasks;
using Users.Presenters.Interfaces;
using Users.UseCasesPorts.Interfaces;

namespace Users.Presenters.Presenters
{
    public class GetUserPresenter : IGetUserOutputPort, IPresenter<TransactionResult>
    {
        public Task Handle()
        {
            throw new NotImplementedException();
        }
    }
}
