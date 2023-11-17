#nullable disable
//using Microsoft.EntityFrameworkCore.sql
using Microsoft.Extensions.Configuration;


namespace Panificadora.Repository
{
    public static class DependencyContainer
    {

        public static IServiceCollection AddServicesRepositories(this IServiceCollection services,
            IConfiguration configuration, string connectionStringName)
        {
            services.AddDbContext<PanificadoraContext>(options =>
            options.UseMySQL(configuration
            .GetConnectionString(connectionStringName)));

            services.AddScoped<IPedidoRepository, PedidoRepository>();

            return services;
        }
    }
}
