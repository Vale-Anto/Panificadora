using ClientesPedidos.ObjetoNegocio.DTOs.ValidaciónDTO;

namespace ClientesPedidos.ObjetoNegocio.Wrappers.Cliente
{
    internal class CrearClienteResponse : WrapperCommon
    {
        public int IdCliente { get; set; }
        public List<ValidaciónErrorDTO> ErroresValidacion { get; set; }

    }
}
