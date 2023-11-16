using ClientesPedidos.ObjetoNegocio.DTOs.ClienteDTOs;
using ClientesPedidos.ObjetoNegocio.DTOs.ValidaciónDTO;
using ClientesPedidos.ObjetoNegocio.Interfaces.EspecificaciónValidación;

namespace PanificadoraUseCases.Especificaciones.EspecificaciónCliente
{
    public class UpdateClienteSpecifications : IEspecificación<ActualizarSolicitudCliente>
    {
        readonly ActualizarSolicitudCliente _entity;
        readonly List<ValidaciónErrorDTO> _errors = new List<ValidaciónErrorDTO>();

        public UpdateClienteSpecifications(ActualizarSolicitudCliente entity)
        {
            _entity = entity;
        }

        public List<ValidaciónErrorDTO> IsValid()
        {
            if (_entity.ClienteId == 0)
            {
                _errors.Add(new ValidaciónErrorDTO()
                {
                    NombrePropiedad = "Id",
                    MensajeError = "Debe especficar el Id que desea actualizar"
                });
            }

            if (string.IsNullOrEmpty(_entity.Nombre))
            {
                _errors.Add(new ValidaciónErrorDTO
                {
                    NombrePropiedad = "Nomre Cliente",
                    MensajeError = "El campo no puede ser nulo ni vacío."

                });
            }
            if (!string.IsNullOrEmpty(_entity.Nombre) && _entity.Nombre.Length > 45)
            {
                _errors.Add(new ValidaciónErrorDTO
                {
                    NombrePropiedad = "Nomre Cliente",
                    MensajeError = "El campo no puede contener más de 45 caracteres."

                });

            }

            return _errors;
        }
    }
}
