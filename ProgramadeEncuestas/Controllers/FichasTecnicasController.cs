using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProgramadeEncuestas.Controllers
{
    public class FichasTecnicasController : Controller
    {
        // GET: FichasTecnicas
        public ActionResult Index()
        {
            return Redirect("/#FichasTecnicas");
        }
    }
}