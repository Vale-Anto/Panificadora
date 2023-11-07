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
        public int Idpedido { get; set; }
        public int Cliente { get; set; }
        public int Fechapedido { get; set; }
        public int Cantidad { get; set; }
        public required string Estado { get; set; } //required es para que si o si contenga algo?
        
    }
}
//todos los atributos que va a tener pedido