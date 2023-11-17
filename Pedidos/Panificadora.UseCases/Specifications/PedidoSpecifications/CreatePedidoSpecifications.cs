using Panificadora.BusinessObject.DTOs.PedidoDTOs;
using Panificadora.BusinessObject.DTOs.ValidationDto;
using Panificadora.BusinessObject.Interfaces.ValidationSpecification;

namespace Panificadora.UseCases.Specifications.PedidoSpecifications
{
    public class CreatePedidoSpecifications : ISpecification<CreatePedidoRequest>
    {
        readonly CreatePedidoRequest _entity; //readonly  indica que estos campos solo se pueden asignar durante la inicialización o en el constructor.
        readonly List<ValidationErrorDto> _errors = new List<ValidationErrorDto>();
        public CreatePedidoSpecifications(CreatePedidoRequest entity)
        {
            this._entity = entity;
        }

        public List<ValidationErrorDto> IsValid()
        {
            if (_entity.Idpedido <=0)
            {
                _errors.Add(new ValidationErrorDto
                {
                    PropertyName = "Idpedido",
                    ErrorMessage = "El campo Idpedido debe contener un valor mayor a 0."

                });
                
      
            }
            

            return _errors;
        }
    }
}

//La palabra clave partial en C# se utiliza para indicar que la definición de una clase, 
//estructura, interfaz o método puede estar dividida en múltiples archivos. Esto significa 
//que puedes tener diferentes fragmentos (archivos) de una clase en diferentes lugares.
