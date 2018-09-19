using Softness.DAO;
using Softness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Softness.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            ViewBag.Usuario = new Usuario() { Pessoa = new Pessoa() { Endereco = new Endereco() } };
            return View();
        }

        public ActionResult AdicionaProfessor(Usuario usuario)
        {
            UsuariosDAO novo = new UsuariosDAO();
            if (usuario != null)
            {
                novo.Adiciona(usuario);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("AdicionaProfessor");
            }
        }

        public ActionResult Autentica(String nomeusuario, String senha)
        {
            UsuariosDAO dao = new UsuariosDAO();
            Usuario usuario = dao.Busca(nomeusuario, senha);
            if (usuario != null)
            {
                Session["usuarioLogado"] = usuario;
                return RedirectToAction("CadastroUsuario", "Usuario");
            }
            else
            {
                return RedirectToAction("Index");
            }


        }
    }
}