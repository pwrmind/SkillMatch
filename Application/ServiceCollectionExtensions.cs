using Damoin.Repositories;
using Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSkillMatchServices(this IServiceCollection services)
        {
            services.AddScoped<IApplicantRepository, ApplicantRepository>();
            //services.AddScoped<IJobRepository, JobRepository>();
            //services.AddScoped<ISkillRepository, SkillRepository>();

            //services.AddScoped<ICreateApplicantCommandHandler, CreateApplicantCommandHandler>();
            //services.AddScoped<IUpdateApplicantCommandHandler, UpdateApplicantCommandHandler>;
            //services.AddScoped<IDeleteApplicantCommandHandler, DeleteApplicantCommandHandler>;

            //services.AddScoped<IGetApplicantsQueryHandler, GetApplicantsQueryHandler>;
            //services.AddScoped<IGetJobsQueryHandler, GetJobsQueryHandler>;

            //services.AddScoped<IApplicantService, ApplicantService>();
            //services.AddScoped<IJobService, JobService>;

            return services;
        }

        public static IServiceCollection AddCustomOptions(this IServiceCollection services, IConfiguration configuration)
        {
            //services.Configure<EmailOptions>(configuration.GetSection("EmailOptions"));
            //services.Configure<StorageOptions>(configuration.GetSection("StorageOptions"));

            return services;
        }
    }

}
