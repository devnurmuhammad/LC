using Education.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Education.Infrastructure
{
    public static class InfrastructureDependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EducationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ConnectionString"), options =>
                options.EnableRetryOnFailure());
            });

            return services;
        }
    }
}
