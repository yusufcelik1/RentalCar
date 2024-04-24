using Entities.Models;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
using Repository.Efcore;
using Services.Contracts;
using Services.EFCore;
using System.Reflection;

namespace WebApp.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigurationSQLContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("Repository")));
        }
        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IReservationRepository, ReservationRepository>();

        }
        public static void ConfigureServiceManager(this IServiceCollection services)
        { // service referanslar

            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
            services.AddScoped<IReservationService, ReservationService>();



        }

        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
