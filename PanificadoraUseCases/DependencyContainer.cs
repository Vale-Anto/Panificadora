namespace PanificadoraUseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesUseCases(this IServiceCollection services)
        {
            services.AddScoped<ICreateActorInputPort, CreateActorIteractor>();

            services.AddScoped<IDeleteActorInputPort, DeleteActorInteractor>();

            services.AddScoped<IUpdateActorInputPort, UpdateActorInteractor>();

            return services;

        }
    }
}