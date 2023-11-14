using Panificadora.BusinessObject.Wrappers.PedidoWrappers;

namespace Panificadora.BusinessObject.Interfaces.Controllers
{
    public interface IDeletePedidoController
    {
        Task<WrapperCreatePedido> DeletePedido(int Idpedido);
    }
}
