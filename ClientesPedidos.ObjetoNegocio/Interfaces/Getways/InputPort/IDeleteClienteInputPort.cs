namespace ClientesPedidos.ObjetoNegocio.Interfaces.Getways.InputPort
{
    public interface IDeleteClienteInputPort
    {
        Task Handle(int IdCliente);

    }
}
