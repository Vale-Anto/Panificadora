using ClientesPedidos.ObjetoNegocio.Interfaces.Controladores;
using ClientesPedidos.ObjetoNegocio.Interfaces.Getways.InputPort;
using ClientesPedidos.ObjetoNegocio.Interfaces.Presentadores.ClientesPrecenters;
using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;

namespace PanificadoraControllers.ClienteControllers
{
    public class DeleteClienteControllers : IDeleteClientController
    {

        readonly IDeleteClienteInputPort _inputPort;
        readonly IDeleteClientePresenter _presenter;

        public DeleteClienteControllers(IDeleteClienteInputPort inputPort, IDeleteClientePresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async Task<DeleteClientResponse> DeleteCliente(int idCliente)
        {
            await _inputPort.Handle(idCliente);
            return _presenter.Cliente;
        }
    }
}
