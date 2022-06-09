using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.DTO;

namespace Users.UseCasesPorts.Interfaces
{
    public interface IGenericInputPort<T>
        where T : BaseDTO
    {
        Task Handle<T>(T dto);
    }
}
