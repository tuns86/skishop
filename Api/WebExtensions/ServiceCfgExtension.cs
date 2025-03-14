using Service.Interfaces;
using Service.Implements;

namespace Api.WebExtensions
{
    public static class ServiceCfgExtension
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}
