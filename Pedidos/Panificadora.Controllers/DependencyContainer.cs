using Microsoft.Extensions.DependencyInjection;
using Panificadora.Controllers.PedidoControllers;

namespace Panificadora.Controllers
{
    public static class DependencyContainer
    {

        public static IServiceCollection AddServicesControllers(this IServiceCollection services)
        {
            services.AddScoped<ICreatePedidoController, CreatePedidoController>();

            services.AddScoped<IDeletePedidoController, DeletePedidoController>();

            services.AddScoped<IUpdatePedidoController, UpdatePedidoController>();

            
            return services;

        }
       
        
    }
}

