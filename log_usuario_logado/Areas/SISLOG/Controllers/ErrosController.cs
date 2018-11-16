using log_usuario_logado.Areas.SISLOG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace log_usuario_logado.Areas.SISLOG.Controllers
{
    public class ErrosController : Controller
    {

         public static void GravarErro(DateTime dh_acesso, string co_sessao, string de_pagina, int co_status_requisicao,  string de_mensagem, string de_excecao)
        {
            SISLOGContexto db = new SISLOGContexto();

            logtb003_log_erro novoLogErro = new logtb003_log_erro()
            {
                dh_acesso = dh_acesso,
                co_sessao = co_sessao,
                co_status_requisicao = co_status_requisicao,
                de_pagina = de_pagina,
                de_mensagem = de_mensagem,
                de_excecao = de_excecao,
            };

            db.logtb003_log_erro.Add(novoLogErro);
            db.SaveChanges();
        }


        /// <summary>
        /// 500 - Erro interno do servidor (Internal Server Error)
        /// </summary>
        public ActionResult Erro500()
        {
            return View();
        }
                     
        /// <summary>
        /// 401 - Não autorizado
        /// </summary>
        public ActionResult Erro401()
        {
            return View();
        }

        /// <summary>
        /// 404 - Não encontrado
        /// </summary>
        public ActionResult Erro404()
        {
            return View();
        }

    }
}