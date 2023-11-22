namespace ClientesPedidos.ObjetoNegocio.Wrappers.Cliente
{
    public class SelectAllClienteResponse : WrapperCommon
    {

        public List<Cliente>? Clientes { get; set; } = new List<Cliente>();

        public class Cliente
        {
            public int IdCliente { get; set; }
            public string NombreCliente { get; set; }
        }

    }
}
