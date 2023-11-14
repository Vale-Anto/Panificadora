
using Panificadora.BusinessObject.DTOs.PedidoDTOs;
using Panificadora.BusinessObject.DTOs.ValidationDto;
using Panificadora.BusinessObject.Interfaces.Getways.PedidoGetways.InputPorts;
using Panificadora.BusinessObject.PersonalException;
using Panificadora.BusinessObject.Wrappers.PedidoWrappers;
using Panificadora.Core.Entidades;
using Panificadora.Core.Interfaces.Repositorio;
using VideoClub.UseCases.Specifications.ActorSpecifications;

namespace Panificadora.UseCases.UseCases.PedidoUseCase
{
    
    /// Clase que implementa el Input Port para crear un pedidoResponse.
    
    public class CreatePedidoIteractor : ICreatePedidoInput
    {
        readonly IPedidoRepository _repository;
        readonly ICreatePedidoPresenter _presenter;

        
        /// Constructor de la clase CreatePedidoIteractor.
       
      
        public CreatePedidoIteractor(IPedidoRepository repository, ICreatePedidoPresenter presenter)
        {
            _repository = repository;// el repositorio depedidos
            _presenter = presenter;// el presenter para crear actores inyección de dependencia
        }

        /// Maneja la creación de un nuevo pedidoResponse.
        
        /// createPedidoRequest: Los datos para crear el pedidoResponse
        /// duvuele el id del nuevo pedidoResponse creado o 0 si hubo errores
        public async Task Handle(CreatePedidoRequest creatPedidoRequest) 
        {
            List<ValidationErrorDto> errors = new List<ValidationErrorDto>();
            errors = ValidatePedido(creatPedidoRequest);
            WrapperCreatePedido pedidoResponse = new();

            if (errors.Any())
            {
                pedidoResponse.ValidationDto = errors;
                await _presenter.Handle(pedidoResponse);
                return;
            }

            PedidoEntidad newPedido = new()
            {
                Idpedido = creatPedidoRequest.Idpedido
            };

            try
            {
                await _repository.Create(newPedido);
                await _repository.SaveChange();
                pedidoResponse.Idpedido = newPedido.Id;
            }
            catch (DBMySqlException ex)
            {
                pedidoResponse.ErrorNumber = ex.Number;
                pedidoResponse.Message = ex.MessageError;
            }
            finally
            {
                await _presenter.Handle(pedidoResponse);
            }
        }

        private List<ValidationErrorDto> ValidatePedido(CreatePedidoRequest creatPedidoRequest)
        {
            var specification = new CreatePedidoSpecifications(creatPedidoRequest);
            return specification.IsValid();
        }
    }

    public interface ICreatePedidoPresenter
    {
        Task Handle(WrapperCreatePedido pedidoResponse); //edir
    }
}