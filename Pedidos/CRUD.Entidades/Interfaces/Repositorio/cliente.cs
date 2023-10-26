using Panificadora.Core.Entidades;

namespace Panificadora.Core.Interfaces.Repositorio
{
    internal class cliente : Header
    {

        Task<cliente> CrearCliente(int clienteId);
        Task<List<cliente>> GetClientes();
        Task<cliente> CreateCliente(Cliente cliente);
        Task<cliente> UpdateCliente(Cliente cliente);
        Task<cliente> DeleteCliente(int clienteId);

    }
}
