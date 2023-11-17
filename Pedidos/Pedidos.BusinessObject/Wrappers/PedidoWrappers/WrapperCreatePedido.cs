using Panificadora.BusinessObject.DTOs.PedidoDTOs;
using Panificadora.BusinessObject.DTOs.ValidationDto;
using Panificadora.BusinessObject.Wrappers;

namespace Panificadora.BusinessObject.Wrappers.PedidoWrappers
{
    public class WrapperCreatePedido : WrapperCommon
    {
        public int Idpedido { get; set; }

        public List<ValidationErrorDto>? ValidationDto { get; set; }
    }

}


