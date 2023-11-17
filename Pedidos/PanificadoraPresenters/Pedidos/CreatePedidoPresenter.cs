
using Pedidos.BusinessObject.Interfaces.Presenters;

namespace PanificadoraPresenters.Pedidos
{
    public class CreatePedidoPresenter : ICreatePedidoPresenter
    {
        public WrapperCreatePedido Pedido { get; private set; } = new WrapperCreatePedido();

        public Task Handle(WrapperCreatePedido pedido)
        {
            this.Pedido = pedido;
            return Task.CompletedTask;
        }
    }
}