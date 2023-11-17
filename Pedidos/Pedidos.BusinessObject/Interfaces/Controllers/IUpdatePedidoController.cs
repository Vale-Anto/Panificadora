using Panificadora.BusinessObject.DTOs.PedidoDTOs;
using Panificadora.BusinessObject.Wrappers.PedidoWrappers;

namespace Panificadora.BusinessObject.Interfaces.Controllers
{
    public interface IUpdatePedidoController
    {
        Task<WrapperCreatePedido> UpdatePedido(UpdatePedidoRequest request);
    }
}
//UpdatePedido recibe un objeto de solicitud (request) para actualizar un pedido y 
//devuelve un resultado encapsulado en un WrapperCreateDeletePedido