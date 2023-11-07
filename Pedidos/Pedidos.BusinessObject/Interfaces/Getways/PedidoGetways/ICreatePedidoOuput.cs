

using AplicationBusinessRules.DTOs.PedidoDTOs;

namespace Pedidos.BusinessObject.Interfaces.Getways.PedidoGetways
{
    public interface ICreatePedidoOuput
    {
        Task Handle(PedidoEntidadDto createPedidoDto);//createPedidoDto tiene los datos del nuevo pedido
    }
}
//ICreatePedidoOuput, define un método Handle (el método Handle crea un pedidoen base a su Id
//que toma un objeto de tipo PedidoEntidadDto.
//Se usa para manejar una entidad de pedido recién creada
    