//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SenalesMioelectricas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class documento
    {
        public int ID_Documento { get; set; }
        public string Nombre_Documento { get; set; }
        public string Nombre_Real { get; set; }
        public byte[] Doc { get; set; }
        public Nullable<int> ID_Paciente { get; set; }
    
        public virtual Paciente Paciente { get; set; }
    }
}
