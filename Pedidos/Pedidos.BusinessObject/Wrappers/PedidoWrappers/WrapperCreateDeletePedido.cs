using AplicationBusinessRules.DTOs.PedidoDTOs;
using Pedidos.BusinessObject.DTOs.ValidationDto;
using Pedidos.BusinessObject.Wrappers;

namespace Pedidos.BusinessObject.Wrappers.PedidoWrappers
{
    public class WrapperCreateDeletePedido : WrapperCommon
    {
        public int Idpedido { get; set; }

        public List<ValidationErrorDto>? ValidationDto { get; set; }
    }

}


 