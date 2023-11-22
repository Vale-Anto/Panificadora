namespace ClientesPedidos.ObjetoNegocio.Interfaces.Getways.InputPort
{

    //Este Input Port se utiliza para recuperar información sobre un cliente
    //específico en función de su Id.
    public interface IGetClienteByIdInputPort
    {
        //El método Handle recibiría el Id del cliente y devolvería un objeto que
        //contiene los detalles del cliente.

        Task Handle(int clienetId);

    }
}
