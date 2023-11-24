using ClientesPedidos.ObjetoNegocio.Interfaces.Getways.OuputPort;
using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;

namespace ClientesPedidos.ObjetoNegocio.Interfaces.Presentadores.ClientesPrecenters
{
    //Este presenter se encarga de manejar la presentación después de recuperar una
    //lista de todos los clientes disponibles en el contexto. 
    public interface IGetClientePresenters : IGetClienteOuputPort
    {
        //Propiedad cliete que contiene la colección de objetos clienteResponse
        //que representan a todos los clientes.
        SelectAllClienteResponse Cliente { get; }

    }
}
