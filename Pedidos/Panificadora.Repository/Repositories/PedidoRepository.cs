using MySql.Data.MySqlClient;
using Panificadora.BusinessObject.PersonalException;
using Panificadora.Core.Entidades;
using Panificadora.Core.Interfaces.Repositorio;
using Panificadora.Repository.Contexto;

namespace Panificadora.Repository.Repositories
{
    public class PedidoRepository : IPedidoRepository


    {
        readonly PanificadoraContext _context;

        public PedidoRepository(PanificadoraContext context)
        {
            _context = context;
        }

        public async Task Create(PedidoEntidad pedido)
        {
            try
            {
                await _context.pedidos.AddAsync(pedido);
            }
            catch (MySqlException ex)
            {
                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

        public async Task Delete(int pedidoId)
        {
            try
            {
                var result = await _context.pedidos.FirstOrDefaultAsync(a => a.Idpedido == pedidoId && a.IsDeleted == false);
                if (result != null)
                {
                    result.IsDeleted = true;
                }
                else
                {
                    throw new DBMySqlException(404, "El registro no fue encontrado");
                }
            }
            catch (MySqlException ex)
            {
                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

        public async Task SaveChange()
        {
            await _context.SaveChangesAsync();
        }

        public Task Update(PedidoEntidad pedido)
        {
            throw new NotImplementedException();
        }
    }
}


