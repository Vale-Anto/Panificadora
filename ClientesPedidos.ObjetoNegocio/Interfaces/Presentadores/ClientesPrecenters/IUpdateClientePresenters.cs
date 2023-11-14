using ClientesPedidos.ObjetoNegocio.Interfaces.Getways.OuputPort;
using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;

namespace ClientesPedidos.ObjetoNegocio.Interfaces.Presentadores.ClientesPrecenters
{
    public interface IUpdateClientePresenters : IUpdateClienteOuputPort
    {

        ActualizarClientesResponse Cliente { get; }

    }
}
