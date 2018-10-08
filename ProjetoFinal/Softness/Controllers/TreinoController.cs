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
            ViewBag.Exercicios = new Exercicio();
            return View();
        }

        public ActionResult AdicionaTreino(Treino treino)
        {
            TreinosDAO dao = new TreinosDAO();
            if (ModelState.IsValid)
            {
                dao.Adiciona(treino);
            }
            return Json(new { Resultado = treino.Id }, JsonRequestBehavior.AllowGet);
        }
    }
}