using ClientesPedidos.ObjetoNegocio.Interfaces.Getways.InputPort;
using ClientesPedidos.ObjetoNegocio.Interfaces.Presentadores.ClientesPrecenters;
using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;
using CRUD.Entidades.Interfaces.Repositorio;

namespace PanificadoraUseCases.UsesCases.UseCasesClientes
{
    public class GetClienteByIdInteractor : IGetClienteByIdInputPort
    {

        private readonly IClienteRepository _repository;
        private readonly IGetClienteByIdPresenters _presenter;

        public GetClienteByIdInteractor(IClienteRepository repository, IGetClienteByIdPresenters presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }
        public async Task Handle(int clienteId)
        {
            SelectClienteResponse clienteResponse = new();

            try
            {
                var existingCliente = await _repository.GetById(clienteId);
                if (existingCliente != null)
                {
                    clienteResponse.IdCliente = existingCliente.Id;
                    clienteResponse.NombreCliente = existingCliente.NombreCliente;
                }
                else
                {
                    clienteResponse.ErrorNumber = 404;
                    clienteResponse.MenssageError = "El Id proporcionado es inválido o no existe.";

                }

            }
            catch (Exception ex)
            {

                clienteResponse.MenssageError = ex.Message;

            }
            finally
            {
                await _presenter.Handle(clienteResponse);
            }
        }

    }
}
