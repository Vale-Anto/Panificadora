using Panificadora.BusinessObject.Wrappers.PedidoWrappers;
namespace Panificadora.BusinessObject.Interfaces.Getways.PedidoGetways.OutputPorts
{
    public interface ICreatePedidoOutput
    {
        Task Handle(WrapperCreatePedido pedido);
    }
}

