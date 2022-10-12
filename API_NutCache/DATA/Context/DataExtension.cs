using DATA.Interfaces;
using DATA.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;



namespace DATA.Context
{
    public static class DataExtension
    {
        public static IServiceCollection AddEntityFramework(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbContext>(options =>
            {
              // options.UseApplicationServiceProvider(ConnectionStrings["conexaoDB"].ConnectionString);
            });

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepositoryBase), typeof(RepositoryBase));
            return services;
        }
    }
}
