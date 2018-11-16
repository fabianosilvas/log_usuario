using System.Web;
using System.Web.Mvc;

namespace log_usuario_logado
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute
            //{
            //    ExceptionType = typeof(System.NotImplementedException),
            //    View = "NotImplemented"
            //});

            filters.Add(new HandleErrorAttribute());
        }
    }
}
