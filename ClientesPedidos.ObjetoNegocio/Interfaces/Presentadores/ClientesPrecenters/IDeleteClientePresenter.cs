using ClientesPedidos.ObjetoNegocio.Interfaces.Getways.OuputPort;
using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;

namespace ClientesPedidos.ObjetoNegocio.Interfaces.Presentadores.ClientesPrecenters
{
    public interface IDeleteClientePresenter : IDeleteClienteOuputPort
    {

        DeleteClientResponse Cliente { get; }

    }
}
