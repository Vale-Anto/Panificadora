using Microsoft.Extensions.DependencyInjection;
using Panificadora.BusinessObject.Interfaces.Getways.PedidoGetways;
using Panificadora.BusinessObject.Interfaces.Getways.PedidoGetways.InputPorts;
using Panificadora.UseCases.UseCases.PedidoUseCase;

namespace Panificadora.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesUseCases(this IServiceCollection services)
        {
            services.AddScoped<ICreatePedidoInput, CreatePedidoIterator>();

            services.AddScoped<IDeletePedidoInput, DeletePedidoIterator>();

            services.AddScoped<IUpdatePedidoInput, UpdatePedidoIterator>();


            return services;

        }
    }
}



