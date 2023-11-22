using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;

namespace ClientesPedidos.ObjetoNegocio.Interfaces.Getways.OuputPort
{
    //Este Output Port se utilizaría para manejar la respuesta o salida después
    //de recuperar la información de un cliente específico.
    public interface IGetClienteByIdOuputPort
    {
        //Maneja la respuesta que se le envía al Presenter con los detalles de un cliente
        //específico según su Id.
        Task Handle(SelectClienteResponse cliente);


    }
}
