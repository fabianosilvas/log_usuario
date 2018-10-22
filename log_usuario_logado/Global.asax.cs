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

    }
}
