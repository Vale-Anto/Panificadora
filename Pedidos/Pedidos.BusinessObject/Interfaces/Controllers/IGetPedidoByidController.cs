
using Pedidos.BusinessObject.Wrappers.PedidoWrappers;

namespace Pedidos.BusinessObject.Interfaces.Controllers
{
    public interface IGetPedidoByidController
    {
        Task<WrapperSelectPedido> GetPedido(int Idpedido);
    }
}
