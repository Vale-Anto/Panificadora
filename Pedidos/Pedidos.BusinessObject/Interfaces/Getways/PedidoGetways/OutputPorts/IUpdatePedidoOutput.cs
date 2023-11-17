using Panificadora.BusinessObject.Wrappers.PedidoWrappers;
namespace Panificadora.BusinessObject.Interfaces.Getways.PedidoGetways.OutputPorts
{
    public interface IUpdatePedidoOutput
    {
        Task Handle(WrapperUpdatePedido pedido);
    }
}
