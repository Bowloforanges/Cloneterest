using Microsoft.Extensions.DependencyInjection;
using Users.UseCases.Interactors;
using Users.UseCasesPorts.Interfaces;

namespace Users.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
        {
            services.AddTransient<IGetUserInputPort, GetUserInteractor>();
            services.AddTransient<IGetAllUsersInputPort, GetAllUsersInteractor>();

            return services;
        }
    }
}
