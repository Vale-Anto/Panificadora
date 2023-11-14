using ClientesPedidos.ObjetoNegocio.DTOs.ValidaciónDTO;

namespace ClientesPedidos.ObjetoNegocio.Interfaces.EspecificaciónValidación
{
    public interface IEspecificación<T> where T : class
    {
        /// <summary>
        /// Valida el objeto según la especificación y devuelve una lista de 
        /// errores de validación.
        /// </summary>
        /// <returns>Una lista de errores de validación. Si la validación es exitosa, 
        /// la lista estará vacía.</returns>
        List<ValidaciónErrorDTO> IsValid();
    }
}
