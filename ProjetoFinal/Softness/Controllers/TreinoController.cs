using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Softness.Controllers
{
    public class TreinoController : Controller
    {
        // GET: Treino
        public ActionResult NovoTreino()
        {
            return View();
        }
    }
}