using Pedidos.BusinessObject.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.BusinessObject.Wrappers.PedidoWrappers
{

    public class WrapperSelectPedido : WrapperCommon
    {
        public int Idpedido { get; set; }
        public DateTime Fechapedido { get; set; } // date en PedidoEntidadDto - datetime acá
    }
}
