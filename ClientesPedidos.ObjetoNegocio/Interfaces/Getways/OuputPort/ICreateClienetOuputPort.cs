using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;

namespace ClientesPedidos.ObjetoNegocio.Interfaces.Getways.OuputPort
{
    public interface ICreateClienetOuputPort
    {
        Task Handle(CreateDeleteClienteResponse cliente);

    }
}
