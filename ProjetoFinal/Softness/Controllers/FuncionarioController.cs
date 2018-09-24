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
        [AutorizacaoFilter]
        public ActionResult Form()
        {
            ViewBag.Funcionario = new Funcionario();
            ViewBag.Funcionario.Pessoa = new Pessoa();
            ViewBag.Funcionario.Pessoa.Endereco = new Endereco();

            return View();
        }

        [AutorizacaoFilter]
        public ActionResult Tabela()
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            IList<Funcionario> funcionarios = dao.Lista();
            ViewBag.Funcionarios = funcionarios;
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
    }
}