

namespace PanificadoraUseCases.Especificaciones.EspecificaciónCliente
{
    public class CreateClienteSpecifications : IEspecificación<CrearSolicitudCliente>
    {
        readonly CreateActorRequest _entity;
        readonly List<ValidationErrorDTO> _errors = new List<ValidationErrorDTO>();
        public CreateActorSpecifications(CreateActorRequest entity)
        {
            this._entity = entity;
        }

        public List<ValidationErrorDTO> IsValid()
        {
            if (string.IsNullOrEmpty(_entity.NombreActor))
            {
                _errors.Add(new ValidationErrorDTO
                {
                    PropertyName = "Nomre Actor",
                    ErrorMessage = "El campo no puede ser nulo ni vacío."

                });
            }
            else if (_entity.NombreActor.Length > 45)
            {
                _errors.Add(new ValidationErrorDTO
                {
                    PropertyName = "Nomre Actor",
                    ErrorMessage = "El campo no puede contener más de 45 caracteres."

                });

            }

            return _errors;
        }
    }

}
}
