using Pedidos.BusinessObject.Interfaces.Presenters;

namespace Panificadora.Controllers.PedidoControllers
{
    public class CreatePedidoController : ICreatePedidoController
    {
        readonly ICreatePedidoInput _inputPort;
        readonly ICreatePedidoPresenter _presenter;

        public CreatePedidoController(ICreatePedidoInput inputPort, ICreatePedidoPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async Task<WrapperCreatePedido> CreatePedido(CreatePedidoRequest pedido)
        {
            await _inputPort.Handle(pedido);
            return _presenter.Pedido;
        }
    }
}
