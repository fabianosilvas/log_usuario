using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using log_usuario_logado.Models;

namespace log_usuario_logado.Controllers
{
    public class ResultadoController : Controller
    {
        private RealizadoContexto db = new RealizadoContexto();

        // GET: Resultado
        public ActionResult Index()
        {
            return View(db.reatb001_resultado.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
