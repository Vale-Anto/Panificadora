using ClientesPedidos.ObjetoNegocio.Interfaces.Getways.InputPort;
using PanificadoraUseCases.UsesCases.UseCasesClientes;

namespace PanificadoraUseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesUseCases(this IServiceCollection services)
        {
            services.AddScoped<ICreateClienteInputPort, CreateClienteInteractor>();

            services.AddScoped<IDeleteClienteInputPort, DeleteClienteInteractor>();

            services.AddScoped<IUpdateClienteInputPort, UpdateClienteInteractor>();

            services.AddScoped<IGetClienteByIdInputPort, GetClienteByIdInteractor>();

            services.AddScoped<IGetClienteInputPort, GetClienteInteractor>();

            return services;

        }


    }
}
