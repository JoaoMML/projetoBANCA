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

        public ActionResult EditaExercicio(int id)
        {
            ExercicioDAO dao = new ExercicioDAO();
            ViewBag.Exercicio = dao.BuscaPorId(id);
            return View();
        }

        public ActionResult AdicionaExercicio(Exercicio exercicio)
        {
            ExercicioDAO dao = new ExercicioDAO();
            if (exercicio != null)
            {
                dao.Adiciona(exercicio);
                return RedirectToAction("Tabela", "Exercicio");
            }
            else
            {
                return RedirectToAction("Novo");
            }
        }

        public ActionResult AtualizaExercicio(Exercicio exercicio)
        {
            ExercicioDAO dao = new ExercicioDAO();
            if (exercicio != null)
            {
                dao.Atualiza(exercicio);
                return RedirectToAction("Tabela", "Exercicio");
            }
            else
            {
                return RedirectToAction("Novo");
            }
        }


        public ActionResult Tabela()
        {
            return View();
        }

        public JsonResult ListaExercicios()
        {
            return Json(new
            {
                data = new ExercicioDAO().ListaExercicios()
        }, JsonRequestBehavior.AllowGet);
        }

        SoftnessContext ctx = new SoftnessContext();
        public ActionResult ListarExercicios()
        {
            var lista = ctx.Exercicios.Where(m => m.Treino.Id == 46);
            return PartialView(lista);
        }

        public ActionResult SalvarExercicios(string exercicio
            , string serie
            , string repeticao
            , string carga
            , string intervalo
            , int idTreino)
        {
            var exer = new Exercicio()
            {
                ExercicioNome = exercicio
                ,
                Series = serie
                ,
                Carga = carga
                ,
                Intervalo = intervalo
                ,
                Treino = ctx.Treinos.Find(idTreino)
            };

            ctx.Exercicios.Add(exer);
            return Json(new { Resultado = exer.Id }, JsonRequestBehavior.AllowGet);

        }
    }
}