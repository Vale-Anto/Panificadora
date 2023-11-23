using MySql.EntityFrameworkCore.Extensions;

namespace Panificadora.Repository.EFCore.Configurations
{
    public class PedidoConfiguration : IEntityTypeConfiguration<PedidoEntidad>
    {
        public void Configure(EntityTypeBuilder<PedidoEntidad> builder) 
        {
            builder.ToTable("pedidos");
            builder.HasKey(p => p.Idpedido); //clave primaria
            builder.Property(p => p.Idpedido)
                .IsRequired()
                .HasColumnName("Idpedido") // el nombre de la colum en la bd
                .HasColumnType("int") //tipo de dato
                .UseMySQLAutoIncrementColumn("Idpedido"); //que es autoincremental

            builder.Property(p => p.Cliente)
            .IsRequired()
            .HasColumnName("Cliente") // Nombre de la columna en la base de datos MySQL.
            .HasColumnType("int"); //Indica el tipo de dato de la columna en MySql.

            builder.Property(p => p.Fechapedido)
               .IsRequired()
               .HasColumnName("Fechapedido")
               .HasColumnType("datetime");

            builder.Property(p => p.Cantidad)
               .IsRequired()
               .HasColumnName("Cantidad")
               .HasColumnType("int");

            builder.Property(p => p.Estado)
               .IsRequired()
               .HasColumnName("Estado")
               .HasColumnType("varchar")
               .HasMaxLength(16);

            builder.Property(p => p.Tipoproducto)
            .IsRequired()
            .HasColumnName("Tipoproducto") 
            .HasColumnType("int");

        }
    }
}



      