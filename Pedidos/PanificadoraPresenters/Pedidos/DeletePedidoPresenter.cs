
using Pedidos.BusinessObject.Interfaces.Presenters;

namespace PanificadoraPresenters.Pedidos
{
    public class DeletePedidoPresenter : IDeletePedidoPresenter
    {
        public WrapperDeletePedido Pedido { get; private set; } = new WrapperDeletePedido();

        public Task Handle(WrapperDeletePedido pedido)
        {
            Pedido.ErrorNumber = pedido.ErrorNumber;
            Pedido.Message = pedido.Message;
            Pedido.Idpedido = pedido.Idpedido;
            return Task.CompletedTask;
        }
    }
}

