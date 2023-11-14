
using Panificadora.BusinessObject.DTOs.PedidoDTOs;
using Panificadora.BusinessObject.Wrappers.PedidoWrappers;

namespace Panificadora.BusinessObject.Interfaces.Controllers
{
    public interface ICreatePedidoController
    {
        Task<WrapperCreatePedido> CreatePedido(PedidoEntidadDto pedido);

    }
}
//define un contrato que dice los métodos que deben implementarse en determinadas clases
//la clase ICreatePedidoController va a implementar
//la interfaz del método de CreatePedido 

