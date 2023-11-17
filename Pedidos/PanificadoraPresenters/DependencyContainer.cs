using Microsoft.Extensions.DependencyInjection;
using Panificadora.BusinessObject.Interfaces.Getways.PedidoGetways.OutputPorts;
using PanificadoraPresenters.Pedidos;
using Pedidos.BusinessObject.Interfaces.Presenters;

namespace Panificadora.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesPresenter(this IServiceCollection services)
        {

            services.AddScoped<ICreatePedidoPresenter, CreatePedidoPresenter>();

            services.AddScoped<IDeletePedidoPresenter, DeletePedidoPresenter>();

            services.AddScoped<IUpdatePedidoPresenter, UpdatePedidoPresenter>();

            return services;
        }
    }
}



