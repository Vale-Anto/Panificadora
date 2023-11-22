using ClientesPedidos.ObjetoNegocio.Interfaces.Getways.InputPort;
using ClientesPedidos.ObjetoNegocio.Interfaces.Presentadores.ClientesPrecenters;
using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;
using CRUD.Entidades.Entidaddes;
using CRUD.Entidades.Interfaces.Repositorio;
using static ClientesPedidos.ObjetoNegocio.Wrappers.Cliente.SelectAllClienteResponse;

namespace PanificadoraUseCases.UsesCases.UseCasesClientes
{
    public class GetClienteInteractor : IGetClienteInputPort
    {

        private readonly IClienteRepository _repository;
        private readonly IGetClientePresenters _presenter;

        public GetClienteInteractor(IClienteRepository repository, IGetClientePresenters presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async ValueTask Handle()
        {
            SelectAllClienteResponse clienteResponse = new();
            try
            {
                var existingCliente = await _repository.GetClientes();

                if (existingCliente != null && existingCliente.Count > 0)
                {
                    foreach (var cliente in existingCliente)
                    {
                        clienteResponse.Clientes.Add(new Cliente
                        {
                            IdCliente = cliente.Id,
                            NombreCliente = cliente.NombreCliente,
                        });

                    }
                }
                else
                {
                    clienteResponse.ErrorNumber = 404;
                    clienteResponse.MenssageError = "No existen registros en la tabla Clientes.";
                }

            }
            catch (DBMySqlException ex)
            {
                clienteResponse.ErrorNumber = ex.Number;
                clienteResponse.MenssageError = ex.MessageError;

            }
            finally
            {
                await _presenter.Handle(clienteResponse);
            }
        }

    }
}
