using ClientesPedidos.ObjetoNegocio.DTOs.ValidaciónDTO;

namespace ClientesPedidos.ObjetoNegocio.Wrappers.Cliente
{    //
    public class ActualizarClientesResponse : WrapperCommon
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }

        public List<ValidaciónErrorDTO>? ValidacionErrores { get; set; }

    }
}
