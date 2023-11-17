using Microsoft.EntityFrameworkCore;
using Panificadora.Core.Entidades;
using Microsoft.EntityFrameworkCore;


namespace Panificadora.Repository.Contexto
{
    // Este código define un contexto de base de datos llamado PanificadoraContext
    // que hereda de DbContext en Entity Framework Core.
    public partial class PanificadoraContext : DbContext
    {
        // El constructor recibe opciones de configuración de DbContext.
        public PanificadoraContext(DbContextOptions<PanificadoraContext> options)

            : base(options) { }

        // DbSet define propiedades para acceder a las tablas en la base de datos.
        public DbSet<PedidoEntidad> pedidos { get; set; }

         
        // Este método se llama al configurar el modelo de base de datos.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aplica configuraciones de entidades desde el ensamblado actual.
            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly());
        }
            //modelBuilder.Entity<PedidoEntidad>().ToTable("pedidos");
            //modelBuilder.Entity<PedidoEntidad>().HasKey(X => X.Idpedido);
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        

            //internal Task AddAsync(PedidoEntidad pedido)
            //{
            //    throw new NotImplementedException();
            //}

            //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}


