using Panificadora.BusinessObject.Interfaces.Getways.PedidoGetways.OutputPorts;
using Panificadora.BusinessObject.Wrappers.PedidoWrappers;

namespace Pedidos.BusinessObject.Interfaces.Presenters
{
    public interface IDeletePedidoPresenter : ICreatePedidoOutput
    {
        WrapperDeletePedido Pedido { get;}

        Task Handle(WrapperDeletePedido pedidoResponse);
    }
}