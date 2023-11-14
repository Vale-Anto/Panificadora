using ClientesPedidos.ObjetoNegocio.Interfaces.Getways.OuputPort;
using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;

namespace ClientesPedidos.ObjetoNegocio.Interfaces.Presentadores.ClientesPrecenters
{
    public interface ICreateClientePresenters : ICreateClienetOuputPort
    {

        CreateDeleteClienteResponse Cliente { get; }

    }
}
