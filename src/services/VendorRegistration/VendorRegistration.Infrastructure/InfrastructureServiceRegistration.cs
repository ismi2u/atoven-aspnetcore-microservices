using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VendorRegistration.Application.Contracts.Infrastructure;
using VendorRegistration.Application.Contracts.Persistence;
using VendorRegistration.Application.Models;
using VendorRegistration.Infrastructure.Mail;
using VendorRegistration.Infrastructure.Persistence;
using VendorRegistration.Infrastructure.Repositories;

namespace VendorRegistration.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {

        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<CompanyContext> (options => options.UseSqlServer (configuration.GetConnectionString("CompanyDBConnectionString")));
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));

            services.Configure<EmailSettings>(c => configuration.GetSection("EmailSettings"));
            services.AddTransient<IEmailService, EmailService>();
            
            return services;
        }
    }
}
