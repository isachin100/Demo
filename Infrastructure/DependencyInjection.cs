using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NewsPlatform.Application.Repositories;
using NewsPlatform.Application.Services;
using NewsPlatform.Infrastructure.Repositories;
using NewsPlatform.Infrastructure.Services;
using WillsPlatform.Application;
using WillsPlatform.Infrastructure;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            #region -- Repositories Registration --
            services.AddScoped<INewsRepository, NewsRepository>();
            #endregion

            #region -- Services Registration --
            services.AddScoped<INewsService, NewsService>();
            #endregion

            services.AddDbContext<ApplicationDbContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });          
            return services;
        }
    }
}
