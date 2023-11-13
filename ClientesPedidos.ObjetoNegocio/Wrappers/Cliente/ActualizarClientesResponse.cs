using ClientesPedidos.ObjetoNegocio.DTOs.ValidaciónDTO;

namespace ClientesPedidos.ObjetoNegocio.Wrappers.Cliente
{    //
    public class ActualizarClientesResponse : WrapperCommon
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }

        public List<ValidaciónErrorDTO>? ValidacionErrores { get; set; }

    }
}
