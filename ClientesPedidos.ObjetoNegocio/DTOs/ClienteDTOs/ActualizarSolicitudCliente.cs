namespace ClientesPedidos.ObjetoNegocio.DTOs.ClienteDTOs
{
    public class ActualizarSolicitudCliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string direccion { get; set; }
        public string codigoPostal { get; set; }
        public string Ciudad { get; set; }

    }
}
