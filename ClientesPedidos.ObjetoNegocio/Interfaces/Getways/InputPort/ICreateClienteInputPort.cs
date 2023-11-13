using ClientesPedidos.ObjetoNegocio.DTOs.ClienteDTOs;

namespace ClientesPedidos.ObjetoNegocio.Interfaces.Getways.InputPort
{
    public interface ICreateClienteInputPort
    {

        Task Handle(CrearSolicitudCliente crearSolicitudCliente);

    }
}
