using ClientesPedidos.ObjetoNegocio.Interfaces.Controladores;
using ClientesPedidos.ObjetoNegocio.Interfaces.Getways.InputPort;
using ClientesPedidos.ObjetoNegocio.Interfaces.Presentadores.ClientesPrecenters;
using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;

namespace PanificadoraControllers.ClienteControllers
{
    public class GetAllClienteControllers : IGetAllClienteController
    {

        readonly IGetClienteInputPort _inputPort;
        readonly IGetClientePresenters _presenter;

        public GetAllClienteControllers(IGetClienteInputPort inputPort, IGetClientePresenters presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<SelectAllClienteResponse> GetCliente()
        {

            await _inputPort.Handle();
            return _presenter.Cliente;

        }
    }
}
