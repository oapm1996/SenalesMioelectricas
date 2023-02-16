using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SenalesMioelectricas.Models
{
    public class MedicoCLS
    {
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido Paterno")]
        public string Apellido_Paterno { get; set; }

        [Display(Name = "Apellido Materno")]
        public string Apellido_Materno { get; set; }

        public ICollection<UsuarioCLS> ID_User { get; set; }
    }
}