using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Users.IoC
{
    public static class DependenyContainer
    {
        public static IServiceCollection AddUsersWSDependencies(this IServiceCollection services, IConfiguration configuration)
        {

            return services;
        }
    }
}
