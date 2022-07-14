using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Users.Mongo.Configurations;
using Users.Mongo.Interfaces;

namespace Users.Mongo
{
    public static class DependencyContainer
    {

        public static IServiceCollection AddMongoDB(this IServiceCollection services, IConfiguration configuration)
        {
            MongoDesigner.Configure();
            services.Configure<MongoOptions>(configuration.GetSection(MongoOptions.MongoSettings));
            services.AddSingleton<IMongoContext, MongoContext>();
            //services.AddScoped<ICreateLineInventoryRepository, CreateLineInventoryRepository>();

            return services;
        }
    }
}
