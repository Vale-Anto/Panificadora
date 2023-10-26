using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AplicationBusinessRules.DTOs.PedidoDTOs
{
    public class PedidoEntidadDto
    {
        public int idpedido { get; set; }
        public int cliente { get; set; } //id cliente
        public Date fechapedido { get; set; }
        public int cantidad { get; set; }


    }
}

//es una clase utilizada para estructurar y transferir datos entre diferentes partes de una
//aplicación, generalmente entre capas o
//componentes, como la capa de presentación, la capa de lógica de negocio
//y la capa de acceso a datos.
//Su propósito principal es proporcionar una forma eficiente y
//organizada de transmitir datos sin exponer la estructura interna de las
//clases de dominio o modelos subyacentes, recibir datos o enviar a la interfaz de ususario