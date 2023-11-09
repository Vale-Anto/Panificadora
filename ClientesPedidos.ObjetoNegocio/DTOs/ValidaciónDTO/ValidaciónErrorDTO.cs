namespace ClientesPedidos.ObjetoNegocio.DTOs.ValidaciónDTO
{
    public class ValidaciónErrorDTO
    {

        //almacena el nombre de la propiedad del objeto o
        //entidad que no pasó la validación
        public string? NombrePropiedad { get; set; }

        //almacena el motivo del error de validación
        public string? MensajeError { get; set; }

    }
}
