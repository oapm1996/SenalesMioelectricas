using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SenalesMioelectricas.Models
{
    public class UsuarioCLS
    {
        [Display(Name = "ID")]
        public int ID_User { get; set; }

        [Display(Name = "Usuario")]
        public string Usuario { get; set; }
        [Display(Name = "Contraseña")]
        public string Contraseña { get; set; }
    }
}