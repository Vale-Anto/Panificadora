using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;

namespace ClientesPedidos.ObjetoNegocio.Interfaces.Getways.OuputPort
{
    //Este Output Port se encargaría de manejar la respuesta o salida después de recuperar
    //una lista de todos los clientes disponibles en el contexto.
    public interface IGetClienteOuputPort
    {
        //Manejala respuesta que se le envia al Presenter con los detalles de la operación
        //de seleccion de todos los Clientes en el contexto. 

        ValueTask Handle(SelectClienteResponse cliente);

    }
}
