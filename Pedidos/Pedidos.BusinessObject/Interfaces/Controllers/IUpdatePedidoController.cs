
using Pedidos.BusinessObject.DTOs.PedidoDTOs;
using Pedidos.BusinessObject.Wrappers.PedidoWrappers;

namespace Pedidos.BusinessObject.Interfaces.Controllers
{
    public interface IUpdatePedidoController
    {
        Task<WrapperUpdateActor> UpdatePedido(UpdatePedidoRequest request);
    }
}
//UpdatePedido recibe un objeto de solicitud (request) para actualizar un actor y 
    //devuelve un resultado encapsulado en un WrapperCreateDeleteActor