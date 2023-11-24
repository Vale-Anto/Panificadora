using ClientesPedidos.ObjetoNegocio.DTOs.ClienteDTOs;
using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;

namespace ClientesPedidos.ObjetoNegocio.Interfaces.Controladores
{
    public interface IUpdateClienteController
    {

        Task<CreateDeleteClienteResponse> UpdateCliente(ActualizarSolicitudCliente request);

    }
}
