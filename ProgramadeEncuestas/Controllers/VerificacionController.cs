using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProgramadeEncuestas.Controllers
{
    public class VerificacionController : Controller
    {
        // GET: VerificacionEncuesta
        public ActionResult Index()
        {
            return Redirect("/#verificacion");
        }
    }
}