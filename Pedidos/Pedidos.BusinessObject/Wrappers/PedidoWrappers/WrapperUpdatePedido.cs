using Pedidos.BusinessObject.DTOs.ValidationDto;


namespace Pedidos.BusinessObject.Wrappers.PedidoWrappers

{
    public class WrapperUpdateActor : WrapperCommon
    {
        public int Idpedido { get; set; }
        public string Estado { get; set; }
        public List<ValidationErrorDto>? ValidationDto { get; set; }
    }
}