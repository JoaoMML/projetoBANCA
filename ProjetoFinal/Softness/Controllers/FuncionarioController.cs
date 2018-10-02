using Softness.DAO;
using Softness.Filtros;
using Softness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Softness.Controllers
{
    
    public class FuncionarioController : Controller
    {
        // GET: Usuario
        public ActionResult Login()
        {
            return View();
        }

        // [Route("/nomeDarotapersonalizada")]  
        //[AutorizacaoFilter]
        public ActionResult Form()
        {
            ViewBag.Funcionario = new Funcionario();
            ViewBag.Funcionario.Pessoa = new Pessoa();
            ViewBag.Funcionario.Pessoa.Endereco = new Endereco();

            return View();
        }

        public ActionResult EditaFuncionario(int id)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            ViewBag.Funcionario = dao.BuscaPorId(id);
            return View();
        }


        //[AutorizacaoFilter]
        public ActionResult Tabela()
        {
            return View();
        }

        public ActionResult Autentica(String nomeusuario, String senha)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            Funcionario usuario = dao.Busca(nomeusuario, senha);
            if (usuario != null)
            {
                Session["usuarioLogado"] = usuario;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Login", "Funcionario");
            }
        }

        //[ValidateAntiForgeryToken] // Valida o Token do form
        public ActionResult AdicionaFuncionario(Funcionario funcionario, string repetindoASenha)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            if(funcionario != null && repetindoASenha == funcionario.Senha)
            {
                funcionario.Ativo = true;
                dao.Adiciona(funcionario);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Form");
            }
        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            return Json(new { saiDaSessao = true });
        }

        public ActionResult AtualizaFuncionario(Funcionario funcionario, string repetindoASenha)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            if (funcionario != null && repetindoASenha == funcionario.Senha)
            {
                funcionario.Ativo = true;
                dao.Atualiza(funcionario);
                return RedirectToAction("Tabela", "Funcionario");
            }
            else
            {
                ViewBag.Pessoa = funcionario;
                return View("EditaFuncionario");
            }
        }

        public JsonResult ListaFuncionarios()
        {
            return Json(new
            {
                data = new FuncionarioDAO().ListaFuncionarios()
            }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ExcluiFuncionario(int id)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.Remover(id);

            return Json(new { excluiu = true }, JsonRequestBehavior.AllowGet);
        }
    }
}