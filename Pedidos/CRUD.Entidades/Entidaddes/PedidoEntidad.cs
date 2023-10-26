using Panificadora.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panificadora.Core.Entidades
{
    public class PedidoEntidad : EntidadesCommon
    {
        public int idpedido { get; set; }
        public int cliente { get; set; }
        public int fechapedido { get; set; }
        public int cantidad { get; set; }
        
    }
}
//todos los atributos que va a tener pedido