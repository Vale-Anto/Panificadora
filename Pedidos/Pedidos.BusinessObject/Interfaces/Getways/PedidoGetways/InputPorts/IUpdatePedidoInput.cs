using Panificadora.BusinessObject.DTOs.PedidoDTOs;

namespace Panificadora.BusinessObject.Interfaces.Getways.PedidoGetways
{
    public interface IUpdatePedidoInput
    {
        Task Handle(UpdatePedidoRequest updatePedidoRequest);
    }
}
