

using Panificadora.BusinessObject.Interfaces.Getways.PedidoGetways.OutputPorts;
using Panificadora.BusinessObject.Wrappers.PedidoWrappers;

namespace Pedidos.BusinessObject.Interfaces.Presenters
{
    public interface ICreatePedidoPresenter : ICreatePedidoOutput
    {
        WrapperCreatePedido Pedido { get;}
    }
}
//el presenter va a manejar la presentacion despues de crear un nuevo pedido
// la propiedad Pedido tiene la información del pedido nuevo
