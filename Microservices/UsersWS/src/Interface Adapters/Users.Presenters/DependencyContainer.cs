using Microsoft.Extensions.DependencyInjection;
using Users.Presenters.Presenters;
using Users.UseCasesPorts.Interfaces;

namespace Users.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<IGetUserOutputPort, GetUserPresenter>();
            services.AddScoped<IGetAllUsersOutputPort, GetAllUsersPresenter>();
            services.AddScoped<ICreateUserOutputPort, CreateUserPresenter>();
            services.AddScoped<IUpdateUserOutputPort, UpdateUserPresenter>();

            return services;
        }
    }
}
