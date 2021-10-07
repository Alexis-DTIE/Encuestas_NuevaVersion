using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Configuration;
using ProgramadeEncuestas.Models;

namespace ProgramadeEncuestas.Controllers
{
    public class HomeController : Controller
    {
        public string ruta = ConfigurationManager.AppSettings["rutafoto"];
        // GET: Home


        DB_INECEntities db = new DB_INECEntities();
        public ActionResult Index(DW_ENCUESTAS model)
        {

            var data = db.DW_ENCUESTAS.ToList();
                      return View(data);
        }

        public ActionResult getEncuestas()
        {
            var lista = db.DW_ENCUESTAS.ToList();
            return View(lista);
        }
        public ActionResult Fichatecnica(string id)
        {
            var ficha = db.DW_ENCUESTAS.Where(x => x.ID_ENCUESTA.ToString().Equals(id)).FirstOrDefault();

            
            return View(ficha);
        }

      
        public JsonResult GetCedula(string cedula)
        {

            using (DB_INECEntities db = new DB_INECEntities())
            {
                var lista = db.V_WEB_PERSONAL_CAMPO.Where(p => p.CEDULA == cedula).Select(p => new
                {    /*Id = p.ID_PERSONAL,*/
                    Nombre = p.NOMBRE,
                    Apellido = p.APELLIDO,
                    Cédula = p.CEDULA,
                    Provincia = p.PROVINCIA,
                    Cargo = p.CARGO,
                    Estado = p.ESTADO,
                    Encuesta = p.ENCUESTA,
                    Teléfono1 = p.TELEFONO1,
                    Teléfono2 = p.TELEFONO2,
                    Foto = ruta + p.FOTO


                });
                var resultado = lista.FirstOrDefault();
                return Json(new { data = resultado }, JsonRequestBehavior.AllowGet);
            }


        }

    }
}