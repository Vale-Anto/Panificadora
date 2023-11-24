using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;

namespace ClientesPedidos.ObjetoNegocio.Interfaces.Controladores
{
    public interface IGetClienteByIdController
    {

        Task<SelectClienteResponse> GetClienteById(int idCliente);

    }
}
