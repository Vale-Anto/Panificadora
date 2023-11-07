
namespace Pedidos.BusinessObject.DTOs.ValidationDto
{
    public class ValidationErrorDto
    {

        public string? PropertyName { get; set; }

        public string? ErrorMessage { get; set; }
    }
}
//almacena los errores de validación y da información sobre qué campo o propiedad generó
//el error y cuál es el mensaje de error asociado
//PropertyName almacena el nombre (valor) de la propiedad que genero un error en la validación
//ErrorMessage almacena el mensaje de error del campo especificado en PropertyName
// ? para que acepte valores nulos