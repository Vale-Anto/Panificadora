using Panificadora.BusinessObject.DTOs.ValidationDto;
using Panificadora.BusinessObject.DTOs.PedidoDTOs;
using Panificadora.BusinessObject.Interfaces.ValidationSpecification;

namespace Panificadora.UseCases.Specifications.PedidoSpecifications
{
    public class UpdatePedidoSpecifications :ISpecification<UpdatePedidoRequest>
    {
        readonly UpdatePedidoRequest _entity;
        readonly List<ValidationErrorDto> _errors = new List<ValidationErrorDto>();

        public UpdatePedidoSpecifications(UpdatePedidoRequest entity)
        {
            _entity = entity;
        }

        public List<ValidationErrorDto> IsValid()
        {
            if (_entity.Idpedido == 0)
            {
                _errors.Add(new ValidationErrorDto()
                {
                    PropertyName = "Id",
                    ErrorMessage = "Debe especficar el Id que desea actualizar"
                });
            }

            return _errors;
        }


    }
}


   
    
        