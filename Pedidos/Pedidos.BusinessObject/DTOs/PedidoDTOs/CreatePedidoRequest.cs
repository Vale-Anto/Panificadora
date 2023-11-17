using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panificadora.BusinessObject.DTOs.PedidoDTOs
{
    public class CreatePedidoRequest
    {
        public int Idpedido { get; set; }
        public DateTime fechapedido { get; set; }
        public int cantidad { get; set; }
        public int cliente { get; set; }
        public int estado { get; set; }
        public int tipoproducto { get; set;}
    }
}
