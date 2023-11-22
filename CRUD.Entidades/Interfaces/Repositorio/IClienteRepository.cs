using CRUD.Entidades.Entidaddes;

namespace CRUD.Entidades.Interfaces.Repositorio
{
    public interface IClienteRepository : IUnitOfWork
    {
        Task<Cliente> GetById(int clienteId);//obtener un cliente por su Id
        Task<List<Cliente>> GetClientes();//obtener lista de clientes
        Task<int> AddCliente(Cliente cliente);// agrega un nuevo cliente a la base de datos
        Task<bool> UpdateCliente(Cliente cliente);//actualizar la información de un cliente existente   
        Task<bool> DeleteCliente(int clienteId);//eliminar un cliente por su Id
        Task<List<Cliente>> GetAllClientes();
    }
}


