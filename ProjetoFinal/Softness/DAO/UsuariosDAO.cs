using Microsoft.EntityFrameworkCore;
using Softness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Softness.DAO
{
    public class UsuariosDAO
    {
        public void Adiciona(Usuario usuario)
        {
            using (var context = new SoftnessContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
        }

        public IList <Pessoa> Lista()
        {
            using (var contexto = new SoftnessContext())
            {
                return contexto.Pessoas.ToList();
            }
        }

        public Pessoa BuscaPorId (int id)
        {
            using (var contexto = new SoftnessContext())
            {
                return contexto.Pessoas.Find(id);
            }
        }

        public void Atualiza(Pessoa pessoa)
        {
            using (var contexto = new SoftnessContext())
            {
                contexto.Entry(pessoa).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public Usuario Busca(string login, string senha)
        {
            using (var contexto = new SoftnessContext())
            {
                return contexto.Usuarios.Include(f => f.Pessoa).FirstOrDefault(f => f.NomeDeUsuario == login && f.Senha == senha);
            }
        }
   
        // FAZER

        // Autentica - bool
        // Inclusao - Insert - void
        // Edicao - BD
    }
}