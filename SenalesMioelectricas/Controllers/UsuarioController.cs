using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SenalesMioelectricas.Models;

namespace SenalesMioelectricas.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            List<UsuarioCLS> userList = null;
            using (var bd = new BDSenalesMioelectricasEntities())
            {
                userList = (from user in bd.Usuarios
                            select new UsuarioCLS
                            {
                                ID_User = user.ID_User,
                                Usuario = user.Usuarios,
                                Contraseña = user.Contraseña
                            }).ToList();
            }
            return View(userList);
        }
    }
}