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

        public ActionResult Form()
        {
            ViewBag.Cliente = new Cliente();
            ViewBag.Cliente.Pessoa = new Pessoa();
            ViewBag.Cliente.Pessoa.Endereco = new Endereco();

            return View();
        }

        public ActionResult Tabela()
        {
            ClienteDAO dao = new ClienteDAO();
            IList<Cliente> clientes = dao.Lista();
            ViewBag.Clientes = clientes;
            return View();
        }

        
        public ActionResult AdicionaCliente(Cliente cliente, string repetindoSenha)
        {
            ClienteDAO dao = new ClienteDAO();
            if( cliente!=null && repetindoSenha == cliente.Senha)
            {
                dao.Adiciona(cliente);
                return RedirectToAction ("Index","Home");
            } else
            {
                return RedirectToAction ("Form");
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

    }
}