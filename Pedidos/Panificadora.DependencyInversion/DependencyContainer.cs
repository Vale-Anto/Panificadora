using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Panificadora.Controllers;
using Panificadora.Presenters;
using Panificadora.Repository;
using Panificadora.UseCases;

namespace Panificadora.DependencyInversion
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPanificadoraServices(this IServiceCollection services,
            IConfiguration configuration, string connectionStringName)
        {
            services
                .AddServicesControllers()
                .AddServicesPresenter()
                .AddServicesRepositories(configuration, connectionStringName)
                .AddServicesUseCases();
            return services;
        }
    }
}

    