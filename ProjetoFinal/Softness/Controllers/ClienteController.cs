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
        public ActionResult Form()
        {
            ViewBag.Funcionario = new Cliente();
            ViewBag.Funcionario.Pessoa = new Pessoa();
            ViewBag.Funcionario.Pessoa.Endereco = new Endereco();

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
    }
}