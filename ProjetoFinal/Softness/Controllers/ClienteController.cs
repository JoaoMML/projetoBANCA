using Softness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Softness.DAO;
using Softness.Filtros;

namespace Softness.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        //[AutorizacaoFilter]
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult EditaCliente(int id)
        {
            ClienteDAO dao = new ClienteDAO();
            ViewBag.Cliente = dao.BuscaPorId(id);
            return View();
        }
  
        public ActionResult Form()
        {
            ViewBag.Cliente = new Cliente();
            ViewBag.Cliente.Pessoa = new Pessoa();
            ViewBag.Cliente.Pessoa.Endereco = new Endereco();

            return View();
        }

        public ActionResult Tabela()
        {
            return View();
        }


        public ActionResult AdicionaCliente(Cliente cliente, string repetindoSenha)
        {
            ClienteDAO dao = new ClienteDAO();
            if (cliente != null && repetindoSenha == cliente.Senha)
            {
                cliente.Ativo = true;
                dao.Adiciona(cliente);
                return RedirectToAction("Tabela", "Cliente");
            }
            else
            {
                return RedirectToAction("Form");
            }
        }

        public ActionResult Autentica(String nomeusuario, String senha)
        {
            ClienteDAO dao = new ClienteDAO();
            Cliente cliente = dao.Busca(nomeusuario, senha);
            if (cliente != null)
            {
                Session["clienteLogado"] = cliente;
                return RedirectToAction("Home", "Cliente");
            }
            else
            {
                return RedirectToAction("Login", "Cliente");
            }

        }
        public JsonResult ListaClientes()
        {
            return Json(new
                {
                data = new ClienteDAO().ListaClientes()
                }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AtualizaCliente(Cliente cliente, string repetindoSenha)
        {
            ClienteDAO dao = new ClienteDAO();
            if (cliente != null && repetindoSenha == cliente.Senha)
            {
                cliente.Ativo = true;
                dao.Atualiza(cliente);
                return RedirectToAction("Tabela", "Cliente");
            }
            else
            {
                ViewBag.Pessoa = cliente;
                return View("EditaCliente");
            }
        }

        public JsonResult ExcluirCliente(int id)
        {
            ClienteDAO dao = new ClienteDAO();
            dao.Remover(id);

            return Json(new { excluiu = true }, JsonRequestBehavior.AllowGet);
        }

    }
}