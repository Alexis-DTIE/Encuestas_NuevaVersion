using ProgramadeEncuestas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramadeEncuestas.Datos
{
    public class Encuesta
    {
        public IEnumerable<DW_ENCUESTAS> Consultar()
        {
            using (DB_INECEntities db = new DB_INECEntities())
                return db.DW_ENCUESTAS.AsNoTracking().ToList();


        }
    }
}