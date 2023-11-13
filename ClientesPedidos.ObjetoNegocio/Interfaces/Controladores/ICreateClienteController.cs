using ClientesPedidos.ObjetoNegocio.DTOs.ClienteDTOs;
using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;

namespace ClientesPedidos.ObjetoNegocio.Interfaces.Controladores
{
    public interface ICreateClienteController
    {

        Task<DeleteClientResponse> CreateCliente(CrearSolicitudCliente request);

    }
}
