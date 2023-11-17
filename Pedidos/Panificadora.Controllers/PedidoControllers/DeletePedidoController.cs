using Panificadora.BusinessObject.Interfaces.Getways.PedidoGetways;
using Pedidos.BusinessObject.Interfaces.Presenters;

namespace Panificadora.Controllers.PedidoControllers
{
    public class DeletePedidoController : IDeletePedidoController
    {
        readonly IDeletePedidoInput _inputPort;
        readonly IDeletePedidoPresenter _presenter;

        public DeletePedidoController(IDeletePedidoInput inputPort, IDeletePedidoPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async Task<WrapperDeletePedido> DeletePedido(int Idpedido)
        {
            await _inputPort.Handle(Idpedido);
            return _presenter.Pedido;
        }
    }
}
