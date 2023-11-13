using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;

namespace ClientesPedidos.ObjetoNegocio.Interfaces.Getways.OuputPort
{
    public interface IUpdateClienteOuputPort
    {
        Task Handle(ActualizarClientesResponse cliente);

    }
}
