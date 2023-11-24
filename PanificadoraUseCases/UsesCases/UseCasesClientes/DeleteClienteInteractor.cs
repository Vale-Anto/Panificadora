using ClientesPedidos.ObjetoNegocio.ExcepciónPersonal;
using ClientesPedidos.ObjetoNegocio.Interfaces.Getways.InputPort;
using ClientesPedidos.ObjetoNegocio.Interfaces.Presentadores.ClientesPrecenters;
using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;
using CRUD.Entidades.Interfaces.Repositorio;

namespace PanificadoraUseCases.UsesCases.UseCasesClientes
{
    public class DeleteClienteInteractor : IDeleteClienteInputPort
    {

        private readonly IClienteRepository _repository;
        private readonly IDeleteClientePresenter _presenter;

        public DeleteClienteInteractor(IClienteRepository repository, IDeleteClientePresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task Handle(int clienteId)
        {

            DeleteClientResponse clienteResponse = new();
            try
            {
                // Obtener el clienteResponse existente por su ID
                //var existingCliete = _repository.GetById(clienteId);

                //if (existingCliente == null)
                //{
                //    // Manejar el caso en el que el clienteResponse no existe
                //    // Devuelve un mensaje indicando que el clienteResponse no se encontró.
                //    clienteResponse.ErrorNumber = 404;
                //    clienteResponse.Message = "El Id proporcionado no es valido o no existe";
                //    await _presenter.Handle(clienteResponse);
                //    return;
                //}

                // Eliminar el cliente
                await _repository.DeleteCliente(clienteId);
                await _repository.SaveChange();
                clienteResponse.IdCliente = clienteId;
            }
            catch (DBMySqlException ex)
            {
                // Manejar errores
                clienteResponse.ErrorNumber = ex.Number;
                clienteResponse.MenssageError = ex.MessageError;
            }
            finally
            {
                // Notificar al presentador que se eliminó un cliente.
                await _presenter.Handle(clienteResponse);
            }

        }

    }
}
