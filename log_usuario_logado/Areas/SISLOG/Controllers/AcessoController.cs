using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using log_usuario_logado.Areas.SISLOG.Models;

namespace log_usuario_logado.Areas.SISLOG.Controllers
{
    public class AcessoController : Controller
    {
        private SISLOGContexto db = new SISLOGContexto();


        public ActionResult Sessoes()
        {
            return View(db.logtb001_log_sessao.ToList());
        }

        public ActionResult Acessos()
        {
            return View(db.logtb002_log_acesso.ToList());
        }

        

        [HttpPost]
        public void LogRequisicao()
        {
            //RECUPERA QUERY STRINGS
            string de_pagina = null;
            if (Request.QueryString["de_pagina"] != null)
            de_pagina = Request.QueryString["de_pagina"].ToString();
            
            string de_resolucao = null;
            if (Request.QueryString["deResolucaoTela"] != null)
            de_resolucao = Request.QueryString["deResolucaoTela"].ToString();
            
            string de_sistema_operacional = null;
            if (Request.QueryString["noSistemaOperacional"] != null)
            de_sistema_operacional = Request.QueryString["noSistemaOperacional"].ToString();

            string de_pagina_origem_requisicao = null;
            if (Request.QueryString["de_pagina_origem_requisicao"] != null)
                de_pagina_origem_requisicao = Request.QueryString["de_pagina_origem_requisicao"].ToString();

            DateTime dh_requisicao = DateTime.Now;

            //VERIFICA SE SESSÃO EXISTE, SE NÃO EXISTIR INSERE NOVO REGISTRO, CASO EXISTA EXCLUI HORÁRIO DA SAIDA DA SESSÃO E ATUALIZA HORARIO DA ÚLTIMA REQUISICAO.
            int sessaoEhExistente = db.logtb001_log_sessao.Where(w => w.co_sessao == Session.SessionID).Count();
            if (sessaoEhExistente == 0)
            {
                logtb001_log_sessao novaSessao = new logtb001_log_sessao
                {
                    dh_acesso = dh_requisicao,
                    dh_ultima_requisicao = dh_requisicao,
                    co_sessao = Session.SessionID,
                    no_usuario = Request.ServerVariables["LOGON_USER"],
                    de_navegador = Request.Browser.Browser,
                    de_resolucao = de_resolucao,
                    de_sistema_operacional = de_sistema_operacional,
                    de_user_agent = Request.ServerVariables["HTTP_USER_AGENT"]
                };
                db.logtb001_log_sessao.Add(novaSessao);
                db.SaveChanges();
            }
            else
            {
                var atualizaSessao = db.logtb001_log_sessao.Where(w => w.co_sessao == Session.SessionID).First();
                atualizaSessao.dh_ultima_requisicao = dh_requisicao;
                atualizaSessao.dh_saida = null;
                atualizaSessao.qt_tempo_sessao = null;
                db.SaveChanges();
            }
           

            //GRAVA LOG DE ACESSO À PAGINA
            logtb002_log_acesso novoAcesso = new logtb002_log_acesso
            {
                dh_acesso = dh_requisicao,
                co_sessao = Session.SessionID,
                de_pagina = de_pagina,
                de_pagina_origem_requisicao = de_pagina_origem_requisicao //Request.ServerVariables["HTTP_REFERER"] 
            };
            db.logtb002_log_acesso.Add(novoAcesso);
            db.SaveChanges();
        }


        public static void LogEncerramentoSessao(String idSessao)
        {
            SISLOGContexto dbSaida = new SISLOGContexto();

            //ATUALIZA DADOS DA SESSAO
            var dhSaida = DateTime.Now;
            var atualizaRegistros = dbSaida.logtb001_log_sessao.Where(w => w.co_sessao == idSessao).First();
            atualizaRegistros.dh_saida = dhSaida;
            atualizaRegistros.qt_tempo_sessao = dhSaida - atualizaRegistros.dh_acesso;
            dbSaida.SaveChanges();
        }


        public ActionResult AbandonarSessao() //Para uso no debug
        {
            Session.Abandon();  // after this Session.End is called
            return RedirectToAction("Index", "Home", new {area= "" });
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
