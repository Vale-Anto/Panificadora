﻿

namespace Panificadora.BusinessObject.DTOs.PedidoDTOs
{
    public class CreatePedidoRequest
    {
        public int Idpedido { get; set; }
        public DateTime fechapedido { get; set; }
        public int cantidad { get; set; }
        public int cliente { get; set; }
        public string estado { get; set; }
        public int tipoproducto { get; set;}
    }
}
