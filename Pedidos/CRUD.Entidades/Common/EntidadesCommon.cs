﻿namespace Panificadora.Core.Common
{
    public class EntidadesCommon
    {

        // todos los datos que tengan en común a una o varias tablas 
        
        public int CreatedBy { get; set; } // es un número entero que representa el
                                           // identificador del usuario que creó la clase
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow; //fecha de creación 
        public int UpdatedBy { get; set; } //s un número entero que representa el identificador del
                                           //usuario que actualizó la clase por última vez
        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow; //fecha actualizadas

        public bool IsDeleted { get; set; } = false;


    }
}
