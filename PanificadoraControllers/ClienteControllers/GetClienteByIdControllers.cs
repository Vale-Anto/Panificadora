using ClientesPedidos.ObjetoNegocio.Interfaces.Controladores;
using ClientesPedidos.ObjetoNegocio.Interfaces.Getways.InputPort;
using ClientesPedidos.ObjetoNegocio.Interfaces.Presentadores.ClientesPrecenters;
using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;

namespace PanificadoraControllers.ClienteControllers
{
    public class GetClienteByIdControllers : IGetClienteByIdController
    {
        readonly IGetClienteByIdInputPort _inputPort;
        readonly IGetClienteByIdPresenters _presenter;

        public GetClienteByIdControllers(IGetClienteByIdInputPort inputPort, IGetClienteByIdPresenters presenters)
        {
            _inputPort = inputPort;
            _presenter = presenters;
        }

        async Task<SelectClienteResponse> IGetClienteByIdController.GetClienteById(int idCliente)
        {
            await _inputPort.Handle(idCliente);
            return _presenter.Cliente;
        }
    }
}
