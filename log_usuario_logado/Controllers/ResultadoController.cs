using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using log_usuario_logado.Areas.SISLOG.Controllers;
using log_usuario_logado.Models;

namespace log_usuario_logado.Controllers
{
    public class ResultadoController : Controller
    {
        private RealizadoContexto db = new RealizadoContexto();

        // GET: Resultado
        public ActionResult Teste()
        {
            throw new Exception("Esto é um exemplo de mensagem de erro");
            return View();
        }

        [HandleError(View = "NotImplemented")]
        //[HandleError(ExceptionType = typeof(SqlException), View = "SqlExceptionView")]
        public ActionResult T500()
        {
            throw new NotImplementedException();
            //string paginaReferencia = Request.ServerVariables["HTTP_REFERER"];
            //Grava log no banco de dados
            //ErrosController.GravarErro(DateTime.Now, Session.SessionID, paginaReferencia, 500, "Página em manutenção", "Exibido mensagem de erro ao usuário: Página em manutenção");
            
            return View();
        }

        public ActionResult NotImplemented()
        {
           
            return View();

        }

        public ActionResult Index()
        {
 
            List<double> listaUnidades2 = new List<double> { 236, 241, 243, 4994 };

            var retorno = db.Reatb001_resultado.Where(w => !listaUnidades2.Contains(w.CO_UNIDADE)).ToList();

            return View(retorno);
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
