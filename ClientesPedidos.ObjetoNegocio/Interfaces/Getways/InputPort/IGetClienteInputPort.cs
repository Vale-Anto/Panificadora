namespace ClientesPedidos.ObjetoNegocio.Interfaces.Getways.InputPort
{
    // Este Input Port se encarga de recuperar una lista de todos los clientes
    // disponibles en el contexto.

    public interface IGetClienteInputPort
    {
        //El método Handle ejecuta una query en el contexto para
        //obtener el contenido dela tabla clientes.
        ValueTask Handle();

    }
}
