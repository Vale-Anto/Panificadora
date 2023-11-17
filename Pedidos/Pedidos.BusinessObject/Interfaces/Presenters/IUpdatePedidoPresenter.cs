using Panificadora.BusinessObject.Interfaces.Getways.PedidoGetways.OutputPorts;
using Panificadora.BusinessObject.Wrappers.PedidoWrappers;

namespace Panificadora.BusinessObject.Interfaces.Presenters
{
    public interface IUpdatePedidoPresenter : IUpdatePedidoOutput
    {
        WrapperUpdatePedido Pedido { get; }
    }
}


