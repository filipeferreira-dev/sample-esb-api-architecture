using Application.Services.Implementations;
using Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.CrossCutting.DependencyInjection
{
    public class DependencyInjectorConfiguration
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ICatalogApplicationService, CatalogApplicationService>();
        }
    }
}
