using ClientesPedidos.ObjetoNegocio.DTOs.ValidaciónDTO;

namespace ClientesPedidos.ObjetoNegocio.Wrappers.Cliente
{
    public class CreateDeleteClienteResponse : WrapperCommon
    {
        public int IdCliente { get; set; }
        public List<ValidaciónErrorDTO>? ValidationErrors { get; set; }
    }
}
