using Microsoft.EntityFrameworkCore;
using WebApi.Contracts.RepositoryWrapper;
using WebApi.Data.Entities;
using WebApi.Repository;

namespace WebApi.Service_Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureMySqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["ConnectionString:MyWorldDBConnection"];
            
            services.AddDbContext<MyWorldDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
           
        }
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
