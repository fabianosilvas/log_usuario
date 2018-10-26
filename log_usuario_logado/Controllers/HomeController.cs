using log_usuario_logado.Areas.SISLOG.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace log_usuario_logado.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.QtUsuarioOnlineSite = AcessoController.UsuariosOnline();
            ViewBag.QtAcessosSiteTotal = AcessoController.QuantidadeAcessos(false);
            ViewBag.QtAcessosSiteUnicos = AcessoController.QuantidadeAcessos(true);
            
            ViewBag.QtUsuarioOnlinePagina = AcessoController.UsuariosOnline("Home");
            ViewBag.QtAcessosPaginaTotal = AcessoController.QuantidadeAcessos("Home", false);
            ViewBag.QtAcessosPaginaUnicos = AcessoController.QuantidadeAcessos("Home", true);


            return View();
        }

        public ActionResult About()
        {
            ViewBag.QtUsuarioOnlineSite = AcessoController.UsuariosOnline();
            ViewBag.QtAcessosSiteTotal = AcessoController.QuantidadeAcessos(false);
            ViewBag.QtAcessosSiteUnicos = AcessoController.QuantidadeAcessos(true);

            ViewBag.QtUsuarioOnlinePagina = AcessoController.UsuariosOnline("About");
            ViewBag.QtAcessosPaginaTotal = AcessoController.QuantidadeAcessos("About", false);
            ViewBag.QtAcessosPaginaUnicos = AcessoController.QuantidadeAcessos("About", true);

            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.QtUsuarioOnlineSite = AcessoController.UsuariosOnline();
            ViewBag.QtAcessosSiteTotal = AcessoController.QuantidadeAcessos(false);
            ViewBag.QtAcessosSiteUnicos = AcessoController.QuantidadeAcessos(true);

            ViewBag.QtUsuarioOnlinePagina = AcessoController.UsuariosOnline("Contact");
            ViewBag.QtAcessosPaginaTotal = AcessoController.QuantidadeAcessos("Contact", false);
            ViewBag.QtAcessosPaginaUnicos = AcessoController.QuantidadeAcessos("Contact", true);

            ViewBag.Message = "Your contact page.";
            return View();
        }

    }
}