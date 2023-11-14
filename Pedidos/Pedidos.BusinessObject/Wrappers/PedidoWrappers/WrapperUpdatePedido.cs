using Panificadora.BusinessObject.DTOs.ValidationDto;


namespace Panificadora.BusinessObject.Wrappers.PedidoWrappers

{
    public class WrapperUpdatePedido : WrapperCommon
    {
        public int Idpedido { get; set; }
        public string Estado { get; set; }
        public List<ValidationErrorDto>? ValidationDto { get; set; }
    }
}