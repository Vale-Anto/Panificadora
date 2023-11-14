using Panificadora.BusinessObject.DTOs.ValidationDto;

namespace Panificadora.BusinessObject.Interfaces.ValidationSpecification
{
    public interface ISpecification<T> where T : class
    {
        List<ValidationErrorDto> IsValid();
    }
}
//la interfaz ISpecification va a representar especificaciones de validacion
//T es el objeto al que se le aplecan esas especificaciones de validación
