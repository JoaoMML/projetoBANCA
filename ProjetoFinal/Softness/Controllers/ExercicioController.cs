using Softness.DAO;
using Softness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Softness.Controllers
{
    public class ExercicioController : Controller
    {
        // GET: Exercicio
        public ActionResult Novo()
        {
            ViewBag.Exercicios = new Exercicio();
            return View();
        }
        public ActionResult AdicionaExercicio(Exercicio exercicio)
        {
            ExercicioDAO dao = new ExercicioDAO();
            if (exercicio != null)
            {
                dao.Adiciona(exercicio);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Novo");
            }
        }

    }
}