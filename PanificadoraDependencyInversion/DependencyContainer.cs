namespace PanificadoraDependencyInversion
{
    internal static class DependencyContainer
    {

        public static IServiceCollection AddVideoClubServices(this IServiceCollection services, IConfiguration configuration, string connectionString)
        {
            services
                .AddServicesRepositories(configuration, connectionString)
                .AddServicesUseCases()
                .AddServicesPresenter()
                .AddServicesControllers();

            return services;
        }

    }
}
