using Panificadora.Core.Common;

namespace Panificadora.Core.Entidades
{
    public class PedidoEntidad : EntidadesCommon
    {
        public int Idpedido { get; set; }
        public int Cliente { get; set; }
        public DateTime Fechapedido { get; set; }
        public int Cantidad { get; set; }
        public string Estado { get; set; } //required es para que si o si contenga algo?
        public int Tipoproducto { get; set; }
    }
}
//todos los atributos que va a tener pedido