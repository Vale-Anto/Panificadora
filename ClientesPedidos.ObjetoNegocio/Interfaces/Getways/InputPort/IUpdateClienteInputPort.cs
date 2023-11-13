using ClientesPedidos.ObjetoNegocio.DTOs.ClienteDTOs;

namespace ClientesPedidos.ObjetoNegocio.Interfaces.Getways.InputPort
{
    public interface IUpdateClienteInputPort
    {

        Task Handle(ActualizarSolicitudCliente actualizarSolicitudCliente);


    }
}
