using Softness.DAO;
using Softness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Softness.Controllers
{
    public class FichaTreinoController : Controller
    {
        public ActionResult FichaTreino()
        {
            ViewBag.FichaTreino = new FichaTreino();
 
            return View();
        }

        public ActionResult AdicionaFicha(FichaTreino ficha)
        {
            FichaTreinoDAO dao = new FichaTreinoDAO();
            if (ficha != null)
            {
                dao.Adiciona(ficha);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("FichaTreino");
            }
        }
    }
}
