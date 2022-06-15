using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Users.Presenters;
using Users.UseCases;

namespace Users.IoC
{
    public static class DependenyContainer
    {
        public static IServiceCollection AddUsersWSDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddUseCasesServices();
            services.AddPresenters();
            return services;
        }
    }
}
