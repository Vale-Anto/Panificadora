namespace loginReglas._01.Emboltorio
{
    internal class ejmEmboltorio
    {
        //los posibles errores que puedan llegar a surgir cuando el usuario haga alguna consulta a la BD 
        // numero de el error y el texto del error en una clase aparte
        // embueln todos los DTO 
    }


}

namespace repEjemplo
{

    public interface clientes
    {
        Task<List<Cliente>> GetClientes()//Devuelve una lista de todos los clientes.
            Task<Cliente> CreateCliente(Cliente cliente);// Crea un nuevo cliente.
        Task<Cliente> UpdateCliente(Cliente cliente); // Actualiza un cliente existente.

        Task<Cliente> DeleteCliente(int clienteId); // Elimina un cliente existente.
    }
