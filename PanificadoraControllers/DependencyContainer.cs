using ClientesPedidos.ObjetoNegocio.Interfaces.Controladores;
using PanificadoraControllers.ClienteControllers;
using static ClientesPedidos.ObjetoNegocio.Interfaces.Controladores.IGetAllClienteController;

namespace PanificadoraControllers
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesControllers(this IServiceCollection services)
        {
            services.AddScoped<ICreateClienteController, CreateClienteController>();///Mantiene los datos (addcoped)

            services.AddScoped<IDeleteClientController, DeleteClienteControllers>();

            services.AddScoped<IUpdateClienteController, UpdateClienteControllers>();

            services.AddScoped<IGetClienteByIdController, GetAllClienteControllers>();

            services.AddScoped<IGetAllActorController, GetAllClienteControllers>();

            return services;

        }

    }
}
