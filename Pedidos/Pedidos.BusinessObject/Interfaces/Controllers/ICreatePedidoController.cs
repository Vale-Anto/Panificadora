using AplicationBusinessRules.DTOs.PedidoDTOs;
using Pedidos.BusinessObject.Wrappers.PedidoWrappers;

namespace Pedidos.BusinessObject.Interfaces.Controllers
{
    public interface ICreatePedidoController
    {
        Task<WrapperCreateDeletePedido> CreatePedido (PedidoEntidadDto pedido);
        Task<WrapperCreateDeletePedido> DeletePedido (int  Idpedido);
    }
}
//define un contrato que dice los métodos que deben implementarse en determinadas clases
//despues voy a hacer una clase que se llama CreatePedidoController y esa clase va a implementar
//la interfaz del método de CreatePedido 

//CONSULTAR! si se puede poner create y delete en el mismo controller
//usando el mismo wrapper para las dos cosas (y si se puede usar el wrapper createdelate para las 2)