using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Organizational.Infrastructure.Data;

namespace Organizational.Infrastructure
{
    public static class InfrastructureDependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OrganizationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ConnectionString"), options =>
                options.EnableRetryOnFailure());
            });

            return services;
        }
    }
}
