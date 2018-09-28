using Softness.Filtros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Softness.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
      [AutorizacaoFilter]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HomeCliente()
        {
            return View();
        }
    }
}