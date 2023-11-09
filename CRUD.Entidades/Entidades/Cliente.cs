using CRUD.Entidades.Common;

namespace CRUD.Entidades.Entidaddes
{
    public class Cliente : EntidadesCommon
    {

        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string apellido { get; set; }
        public string DNI { get; set; }
        public string direccion { get; set; }
        public string codigoPostal { get; set; }
        public string Ciudad { get; set; }

    }
}
