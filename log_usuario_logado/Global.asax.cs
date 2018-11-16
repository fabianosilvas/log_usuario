using log_usuario_logado.Areas.SISLOG.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace log_usuario_logado
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);         
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Application["ContadorAcessos"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application["ContadorAcessos"] = (int)(Application["ContadorAcessos"]) + 1;

            //Define primeira váriavel de sessão, para poder criar o ID único da Sessão e utilizar no log de encerramento da sessão
            Session["idSessao"] = Session.SessionID;
        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application["ContadorAcessos"] = (int)(Application["ContadorAcessos"]) - 1;

            //Atualiza hora do encerramento da sessão no log
            AcessoController.LogEncerramentoSessao(Session["idSessao"].ToString());
            Session["idSessao"] = null;
        }



        protected void Application_Error(object sender, EventArgs e)
        {
            Exception excecao = Server.GetLastError();
            
            //Define variáveis para gravar log
            string co_sessao = Session["idSessao"].ToString();
            int co_status_requisicao = Response.StatusCode;
            string de_pagina = Request.Url.ToString(); ;
            string de_mensagem = excecao.Message;
            string de_excecao = excecao.StackTrace;

            Response.Clear();

            //Tenta identificar se erro é http 404
            HttpException httpExcecao = excecao as HttpException;
            if (httpExcecao != null)
                co_status_requisicao = httpExcecao.GetHttpCode();
                 
            //Grava log no banco de dados
            ErrosController.GravarErro(DateTime.Now, co_sessao, de_pagina, co_status_requisicao,  de_mensagem , de_excecao);

            //Define action que será renderizada
            string action = null;
            switch (co_status_requisicao)
            {
                case 401:
                    action = "Erro401";
                    break;
                case 404:
                    action = "Erro404";
                    break;
                case 500:
                    action = "Erro500";
                    break;
                default:
                    action = "Erro500";
                    break;
            }

            // clear error on server
            Server.ClearError();

            //Redireciona página
            Response.Redirect(String.Format("~/SISLOG/Erros/{0}", action));
        }

    }
}
