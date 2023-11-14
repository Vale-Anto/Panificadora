using Panificadora.BusinessObject.Wrappers.PedidoWrappers;
namespace Panificadora.BusinessObject.Interfaces.Getways.PedidoGetways.OutputPorts
{
    public interface IDeletePedidoOutput
    {
        Task Handle(WrapperDeletePedido pedido);
    }
}

