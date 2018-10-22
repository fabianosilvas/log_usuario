using System.Web.Mvc;

namespace log_usuario_logado.Areas.SISLOG
{
    public class SISLOGAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "SISLOG";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "SISLOG_default",
                "SISLOG/{controller}/{action}/{id}",
                new { controller = "Acesso", action = "Sessoes", id = UrlParameter.Optional }
            );
        }
    }
}