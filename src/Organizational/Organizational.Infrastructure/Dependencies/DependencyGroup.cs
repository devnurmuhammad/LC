using Microsoft.Extensions.DependencyInjection;
using Organizational.Application.Interfaces.Repositories;
using Organizational.Application.Interfaces.Services;
using Organizational.Application.Services;
using Organizational.Infrastructure.Repositories;

namespace Organizational.Infrastructure.Dependencies
{
    public static class DependencyGroup
    {
        public static IServiceCollection AddDependencyGroup(this IServiceCollection services)
        {
            services.AddScoped<ICompanyRepository, CompanyRepository>()
                    .AddScoped<ICompanyService, CompanyService>();

            return services;
        }
    }
}
