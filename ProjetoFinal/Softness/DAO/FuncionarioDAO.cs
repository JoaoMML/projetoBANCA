using Microsoft.EntityFrameworkCore;
using Softness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Softness.DAO
{
    public class FuncionarioDAO
    {
        public void Adiciona(Funcionario funcionario)
        {
            using (var context = new SoftnessContext())
            {
                context.Funcionarios.Add(funcionario);
                context.SaveChanges();
            }
        }

        public IList<Funcionario> Lista()
        {
            using (var contexto = new SoftnessContext())
            {
                return contexto.Funcionarios.Include("Pessoa").ToList();
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
        public void Remover(Funcionario funcionario)
        {
            using (var context = new SoftnessContext()) { 
            context.Funcionarios.Remove(funcionario);
            context.SaveChanges();
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