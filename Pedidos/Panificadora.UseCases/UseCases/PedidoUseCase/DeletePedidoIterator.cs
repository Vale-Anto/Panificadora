using Panificadora.BusinessObject.Interfaces.Getways.PedidoGetways;
using Panificadora.BusinessObject.Interfaces.Getways.PedidoGetways.InputPorts;
using Panificadora.BusinessObject.Interfaces.Presenters;
using Panificadora.BusinessObject.PersonalException;
using Panificadora.BusinessObject.Wrappers.PedidoWrappers;
using Panificadora.Core.Entidades;
using Panificadora.Core.Interfaces.Repositorio;
using Pedidos.BusinessObject.Interfaces.Presenters;
using VideoClub.UseCases.Specifications.ActorSpecifications;

namespace VideoClub.UseCases.UseCases.ActorUseCase
{
    public class DeletePedidoInteractor : IDeletePedidoInput
    {
        private readonly IPedidoRepository _repository;
        private readonly IDeletePedidoPresenter _presenter;

        public DeletePedidoInteractor(IPedidoRepository repository, IDeletePedidoPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task Handle(int idPedido)
        {

            WrapperDeletePedido pedidoResponse = new();
            try
            {
                // Eliminar el pedido
                await _repository.Delete(idPedido);
                await _repository.SaveChange();
                pedidoResponse.Idpedido = idPedido;
            }
            catch (DBMySqlException ex)
            {
                // Manejar errores
                pedidoResponse.ErrorNumber = ex.Number;
                pedidoResponse.Message = ex.MessageError;
            }
            finally
            {
                // Notificar al presentador que se eliminó el pedido.
                await _presenter.Handle(pedidoResponse);
            }

        }
    }
}

//El propósito principal de esta clase es eliminar un
//pedido utilizando un identificador (idPedido).
//encapsula la lógica para eliminar un actor, maneja las excepciones relacionadas 
//con la base de datos 
//y notifica al presentador sobre el resultado de la operación.
//readonly es como un letrero que pones en una caja cuando la llenas por primera vez.
//Después de poner ese letrero, nadie puede cambiar el contenido de la caja.
//Es útil cuando quieres asegurarte de que un valor no cambie después de haber sido
//configurado al principio.
//Piensa en ello como una especie de "sello de una sola vez".