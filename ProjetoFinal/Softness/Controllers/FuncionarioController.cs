using Softness.DAO;
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
        public ActionResult Form()
        {
            ViewBag.Funcionario = new Funcionario();
            ViewBag.Funcionario.Pessoa = new Pessoa();
            ViewBag.Funcionario.Pessoa.Endereco = new Endereco();

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
        public ActionResult AdicionaFuncioanrio(Funcionario funcionario)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            if(funcionario != null)
            {
                dao.Adiciona(funcionario);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Form");
            }
        }
    }
}