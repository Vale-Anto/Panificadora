using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;

namespace ClientesPedidos.ObjetoNegocio.Interfaces.Controladores
{
    public interface IDeleteClientController
    {

        Task<DeleteClientResponse> Handle(int? id);
        /// tiene una relacion con el inputpor y el precentador
        /// deben tener un constructor
        /// cuando yo instancie tengo que pasarle quien es el controlador y el inputport(mane)
        /// createractorresponse cliente get, set
        /// list validaciondeerror? validacionerror
        /// createractorresponse: solo va a tener el id
    }

}
