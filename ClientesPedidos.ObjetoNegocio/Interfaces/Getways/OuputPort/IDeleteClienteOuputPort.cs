using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;

namespace ClientesPedidos.ObjetoNegocio.Interfaces.Getways.OuputPort
{
    public interface IDeleteClienteOuputPort
    {

        Task Handle(DeleteClientResponse cliente);


    }
}
