using Panificadora.BusinessObject.DTOs.PedidoDTOs;
using Panificadora.BusinessObject.DTOs.ValidationDto;
using Panificadora.BusinessObject.Interfaces.Presenters;
using Panificadora.Core.Entidades;
using Panificadora.Core.Interfaces.Repositorio;
using Panificadora.BusinessObject.Wrappers.PedidoWrappers;
using Panificadora.UseCases.Specifications.PedidoSpecifications;
using Panificadora.BusinessObject.Interfaces.Getways.PedidoGetways;

namespace Panificadora.UseCases.UseCases.PedidoUseCase
{
    public class UpdatePedidoIterator : IUpdatePedidoInput
    {
        private readonly IPedidoRepository _repository;
        private readonly IUpdatePedidoPresenter _presenter;

        public UpdatePedidoIterator(IPedidoRepository repository, IUpdatePedidoPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task Handle(UpdatePedidoRequest updatePedidoRequest)
        {
            List<ValidationErrorDto> errors = new List<ValidationErrorDto>();
            WrapperUpdatePedido pedidoResponse = new();
            try
            {      //Valida los datos del pedidoResponse a actualizar.
                errors = ValidationErrors(updatePedidoRequest);


                if (errors.Any())
                {
                    // se encarga si pedidoResponse no cumple con las validaciones.
                    // Devuelve un mensaje indicando que los datos del pedidoResponse no son validos.
                    pedidoResponse.ValidationDto = errors;
                    await _presenter.Handle(pedidoResponse);
                    return;
                }
             }
            //// Obtener el pedidoResponse existente por su ID
            //PedidoEntidad existingPedidoEntidad = await _repository.GetById(updatePedidoRequest.Idpedido);
            //if (existingPedidoEntidad == null)
            //{
            //    // se encarga si el pedidoResponse no existe
            //    // Devuelve un mensaje de error indicando que el pedidoResponse no se encontró
            //    pedidoResponse.ErrorNumber = 404;
            //    pedidoResponse.Message = $"El pedido con {updatePedidoRequest.Idpedido} no existe";
            //    await _presenter.Handle(pedidoResponse);
            //    //    return;
            //    }
            //    // Actualiza la información del pedidoResponse con los datos proporcionados
            //    existingPedidoEntidad.Idpedido = updatePedidoRequest.Idpedido;
            //    //updatePedidoRequest contiene los detalles actualizados del pedido

            //    // hace la actualización en el repositorio
            //    await _repository.Update(existingPedidoEntidad);
            //    await _repository.SaveChange();
            //    // crea un objeto de respuesta exitosa
            //    pedidoResponse.Idpedido = existingPedidoEntidad.Id;
            //    pedidoResponse.Idpedido = existingPedidoEntidad.Idpedido;
            //    // le manda la respuesta al presentador
            //    await _presenter.Handle(pedidoResponse);
            //}
            catch (Exception ex)
            {
                // maneja los errores que puedan salir durante la actualización
                pedidoResponse.Message = ex.Message;

            }
            finally
            {
                await _presenter.Handle(pedidoResponse);
            }
        }

        private List<ValidationErrorDto> ValidationErrors(UpdatePedidoRequest updatePedidoRequest)
        {
            var specification = new UpdatePedidoSpecifications(updatePedidoRequest);
            return specification.IsValid();
        }

    }


}
