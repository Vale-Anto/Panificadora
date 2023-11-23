
using Panificadora.BusinessObject.DTOs.PedidoDTOs;
using Panificadora.BusinessObject.DTOs.ValidationDto;
using Panificadora.BusinessObject.Interfaces.Getways.PedidoGetways.InputPorts;
using Panificadora.BusinessObject.PersonalException;
using Panificadora.BusinessObject.Wrappers.PedidoWrappers;
using Panificadora.Core.Entidades;
using Panificadora.Core.Interfaces.Repositorio;
using Panificadora.UseCases.Specifications.PedidoSpecifications;
using Pedidos.BusinessObject.Interfaces.Presenters;

namespace Panificadora.UseCases.UseCases.PedidoUseCase
{

    /// Clase que implementa el Input Port para crear un pedidoResponse.

    public class CreatePedidoIterator : ICreatePedidoInput
    {
        readonly IPedidoRepository _repository;
        readonly ICreatePedidoPresenter _presenter;


        /// Constructor de la clase CreatePedidoIteractor.


        public CreatePedidoIterator(IPedidoRepository repository, ICreatePedidoPresenter presenter)
        {
            _repository = repository;// el repositorio depedidos
            _presenter = presenter;// el presenter para crear pedidos inyección de dependencia
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

            //PedidoEntidad newPedido = new()
            //{
            //    Idpedido = creatPedidoRequest.Idpedido
            //};

            try
            {
                PedidoEntidad entidad = MapToEntity(creatPedidoRequest);
                await _repository.Create(entidad);
                await _repository.SaveChange();
                pedidoResponse.Idpedido = entidad.Idpedido;
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
        private PedidoEntidad MapToEntity(CreatePedidoRequest request)
        {
            PedidoEntidad entidad = new PedidoEntidad();
            entidad.Cantidad = request.cantidad;
            entidad.Fechapedido = request.fechapedido;
            entidad.Tipoproducto = request.tipoproducto;
            entidad.Estado = request.estado;
            entidad.Cliente = request.cliente;
            return entidad;
        }
    }

}