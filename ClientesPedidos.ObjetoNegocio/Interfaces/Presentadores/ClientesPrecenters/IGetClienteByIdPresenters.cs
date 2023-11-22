using ClientesPedidos.ObjetoNegocio.Interfaces.Getways.OuputPort;
using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;

namespace ClientesPedidos.ObjetoNegocio.Interfaces.Presentadores.ClientesPrecenters
{
    //Este presenter se utiliza para manejar la presentación después de recuperar la
    //información de un cliente específico por su Id.
    public interface IGetClienteByIdPresenters : IGetClienteByIdOuputPort
    {
        //Propiedad cliente que contiene los detalles del cliente recuperado.

        SelectClienteResponse Cliente { get; }


    }
}
