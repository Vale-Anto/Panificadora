using ClientesPedidos.ObjetoNegocio.Interfaces.Getways.InputPort;
using ClientesPedidos.ObjetoNegocio.Interfaces.Presentadores.ClientesPrecenters;

namespace PanificadoraUseCases.UsesCases.UseCasesClientes
{
    public class CreateClienteInteractor : ICreateClienteInputPort
    {
        readonly IClienteRepository _repository;
        readonly ICreateClientePresenters _presenters;


        public CreateClienteInteractor(IClienteRepository repository, ICreateClientePresenters presenters)
        {

            _repository = repository;
            _presenters = presenters;

        }
        public async Task handle
    }
}
