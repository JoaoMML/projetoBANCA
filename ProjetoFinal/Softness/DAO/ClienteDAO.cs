using Microsoft.EntityFrameworkCore;
using Softness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Softness.DAO
{
    public class ClienteDAO
    {
        public void Adiciona(Cliente cliente)
        {
            using (var context = new SoftnessContext())
            {
                context.Cliente.Add(cliente);
                context.SaveChanges();
            }
        }

        public IList<Funcionario> Lista()
        {
            using (var contexto = new SoftnessContext())
            {
                return contexto.Funcionarios.ToList();
            }
        }

        public Funcionario BuscaPorId(int id)
        {
            using (var contexto = new SoftnessContext())
            {
                return contexto.Funcionarios.Find(id);
            }
        }

        public void Atualiza(Funcionario Funcionarios)
        {
            using (var contexto = new SoftnessContext())
            {
                contexto.Entry(Funcionarios).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public Funcionario Busca(string login, string senha)
        {
            using (var contexto = new SoftnessContext())
            {
                return contexto.Funcionarios.Include(f => f.Pessoa).FirstOrDefault(f => f.NomeDeUsuario == login && f.Senha == senha);
            }
        }
    }
}