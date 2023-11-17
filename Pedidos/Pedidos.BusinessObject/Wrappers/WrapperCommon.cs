namespace Panificadora.BusinessObject.Wrappers
{
    public class WrapperCommon
    {
        public int ErrorNumber { get; set; }
        public string? Message { get; set; }
    }
}
//tengo que devolver una lista de validaciones
//si no puedo devolver lo que me pide le tengo que devolver un número de error
//y un mensaje para ese error
//creo una clase que va a contener eso los dto van a heredar de esa clase (los dto tienen el id)