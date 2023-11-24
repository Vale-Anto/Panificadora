using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;

namespace ClientesPedidos.ObjetoNegocio.Interfaces.Controladores
{
    public interface IGetAllClienteController
    {

        public interface IGetAllActorController
        {
            ValueTask<SelectAllClienteResponse> GetCliente();
        }

    }
}
