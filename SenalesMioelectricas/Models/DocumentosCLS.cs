using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SenalesMioelectricas.Models
{
    public class DocumentosCLS
    {
        [Display(Name ="ID")]
        public int ID_Documento { get; set; }
        [Display(Name ="Nombre")]
        public  string Nombre_Real { get; set; }
        [Display(Name = "Documento")]
        public string Doc { get; set; }
        public ICollection<PacienteCLS> ID_Paciente { get; set; }
    }
}