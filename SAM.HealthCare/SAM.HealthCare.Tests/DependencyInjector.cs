using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SAM.HealthCare.Domain.IRepositories;
using SAM.HealthCare.Infrastructure.DatabaseContext;
using SAM.HealthCare.Infrastructure.Repositories;
using SAM.HealthCare.Services.Services;

namespace SAM.HealthCare.Tests
{
    internal static class DependencyInjector
    {
        public static IServiceProvider GetServiceProvider()
        {
            var services = new ServiceCollection();

            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICompanyService, CompanyService>();

            InitializeDbContext(services);

            return services.BuildServiceProvider();
        }
        private static void InitializeDbContext(IServiceCollection services)
        {
            services.AddEntityFrameworkInMemoryDatabase()
                .AddDbContext<HealthCareDbContext>(options =>
                    {
                        options.UseInMemoryDatabase(nameof(HealthCareDbContext));
                    }
                );
        }
    }
}