

using ClientesPedidos.ObjetoNegocio.DTOs.ClienteDTOs;
using ClientesPedidos.ObjetoNegocio.DTOs.ValidaciónDTO;
using ClientesPedidos.ObjetoNegocio.Interfaces.EspecificaciónValidación;

namespace CRUD.PanificadoraUseCases.Especificaciones.EspecificaciónCliente
{
    public class CreateClienteSpecifications : IEspecificación<CrearSolicitudCliente>
    {
        readonly CrearSolicitudCliente _entity;
        readonly List<ValidaciónErrorDTO> _errors = new List<ValidaciónErrorDTO>();
        public CreateClienteSpecifications(CrearSolicitudCliente entity)
        {
            this._entity = entity;
        }

        public List<ValidaciónErrorDTO> IsValid()
        {
            if (string.IsNullOrEmpty(_entity.NombreCliente))
            {
                _errors.Add(new ValidaciónErrorDTO
                {
                    NombrePropiedad = "Nomre Cliente",
                    MensajeError = "El campo no puede ser nulo ni vacío."

                });
            }
            else if (_entity.NombreCliente.Length > 45)
            {
                _errors.Add(new ValidaciónErrorDTO
                {
                    NombrePropiedad = "Nomre Cliente",
                    MensajeError = "El campo no puede contener mas de 45 caracteres."

                });

            }

            return _errors;
        }
    }

}

