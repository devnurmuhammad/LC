using Education.Application.Interfaces;
using Education.Application.Repositories;
using Education.Application.Repository;
using Education.Application.Services;
using Education.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Education.Infrastructure.Dependencies
{
    public static class DependencyGroup
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services
                    .AddScoped<IStudentRepository, StudentRepository>()
                    .AddScoped<IStudentService, StudentService>()
                    .AddScoped<ITeacherRepository, TeacherRepository>()
                    .AddScoped<ITeacherService, TeacherService>()
                    .AddScoped<ISubjectRepository, SubjectRepository>()
                    .AddScoped<ISubjectService, SubjectService>()
                    .AddScoped<IGroupRepository, GroupRepository>()
                    .AddScoped<IGroupService, GroupService>();

            return services;
        }
    }
}
