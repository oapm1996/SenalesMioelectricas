using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SenalesMioelectricas.Models;

namespace SenalesMioelectricas.Controllers
{
    public class PacienteController : Controller
    {
        // GET: Paciente
        public ActionResult Index()
        {
            List<PacienteCLS> pacienteList = null;
            using (var bd = new BDSenalesMioelectricasEntities())
            {
                pacienteList = (from paciente in bd.Pacientes
                                select new PacienteCLS
                                { 
                                    Nombre = paciente.Nombre,
                                    Apellido_Paterno = paciente.Apellido_Paterno,
                                    Apellido_Materno = paciente.Apellido_Materno,
                                    Sexo = paciente.Sexo
                                }).ToList();
            }
                return View(pacienteList);
        }
    }
}