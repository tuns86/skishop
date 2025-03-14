using Core.IRepositories;
using Infrastructure.Repositories;

namespace Api.WebExtensions
{
    public static class RepositoryCfgExtension
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
