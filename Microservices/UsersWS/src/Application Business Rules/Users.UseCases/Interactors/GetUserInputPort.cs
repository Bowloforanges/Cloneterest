
using System.Threading.Tasks;
using Users.DTO;
using Users.UseCasesPorts.Interfaces;

namespace Users.UseCases.Interactors
{
    public class GetUserInputPort : IGenericInputPort<GetUserDTO>
    {

        private readonly string _name;

        public GetUserInputPort(string name) => (_name) = (name);

        public async Task Handle<T>(T dto)
        {
            System.Console.WriteLine($"----- this is provided '{_name}'");
            await Task.CompletedTask;
        }
    }
}
