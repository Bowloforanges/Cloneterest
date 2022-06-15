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
            return services;
        }
    }
}
