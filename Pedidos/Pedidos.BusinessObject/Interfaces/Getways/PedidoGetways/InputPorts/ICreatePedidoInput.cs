using Panificadora.BusinessObject.DTOs.PedidoDTOs;


namespace Panificadora.BusinessObject.Interfaces.Getways.PedidoGetways.InputPorts
{
    public interface ICreatePedidoInput
    {
        Task Handle(CreatePedidoRequest createPedidoDto);//createPedidoDto tiene los datos del nuevo pedido
    }
}
//ICreatePedidoOuput, define un método Handle (el método Handle crea un pedido en base a su Id)
//que toma un objeto de tipo PedidoEntidadDto con el que va a crear un nuevo registro
//en el input van a entrar los datos que transporta el dto
