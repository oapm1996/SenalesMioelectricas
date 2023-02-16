using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SenalesMioelectricas.Models
{
    public class PacienteCLS
    {
        [Display(Name = "ID")]
        public int ID_Paciente { get; set; }

        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido Paterno")]
        public string Apellido_Paterno { get; set; }

        [Display(Name = "Apellido Materno")]
        public string Apellido_Materno { get; set; }

        [Display(Name = "Sexo")]
        public string Sexo { get; set; }
        public ICollection<MedicoCLS> ID_Medico { get; set; }
    }
}