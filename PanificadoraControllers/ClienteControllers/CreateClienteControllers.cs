using ClientesPedidos.ObjetoNegocio.DTOs.ClienteDTOs;
using ClientesPedidos.ObjetoNegocio.Interfaces.Controladores;
using ClientesPedidos.ObjetoNegocio.Interfaces.Getways.InputPort;
using ClientesPedidos.ObjetoNegocio.Interfaces.Presentadores.ClientesPrecenters;
using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;

namespace PanificadoraControllers.ClienteControllers
{
    public class CreateClienteController : ICreateClienteController

    {
        readonly ICreateClienteInputPort _inputPort;
        readonly ICreateClientePresenters _presenters;

        public CreateClienteController(ICreateClienteInputPort inputPort, ICreateClientePresenters presenters)
        {
            _inputPort = inputPort;
            _presenters = presenters;
        }

        public async Task<CreateDeleteClienteResponse> CreateCliente(CrearSolicitudCliente request)
        {

            await _inputPort.Handle(request);
            return _presenters.Cliente;

        }
    }



}
