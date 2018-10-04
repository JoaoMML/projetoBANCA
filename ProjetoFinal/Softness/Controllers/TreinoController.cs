using Softness.DAO;
using Softness.Models;
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
        public ActionResult Novo()
        {
            return View();
        }

        public ActionResult AdicionaTreino(Treino treino)
        {
            TreinosDAO dao = new TreinosDAO();
            if (treino != null)
            {
                dao.Adiciona(treino);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Novo");
            }
        }
    }
}