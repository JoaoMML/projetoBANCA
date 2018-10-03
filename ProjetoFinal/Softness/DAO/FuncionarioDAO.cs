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
        public Funcionario BuscaPorId(int id)
        {
            using (var contexto = new SoftnessContext())
            {
                return contexto.Funcionarios.Include(p => p.Pessoa).ThenInclude(e => e.Endereco).Where(i => i.Id == id).FirstOrDefault();
            }
        }

        public void Atualiza(Funcionario funcionario)
        {
            using (var contexto = new SoftnessContext())
            {
                contexto.Funcionarios.Update(funcionario);
                contexto.SaveChanges();
            }
        }

        public void Remover(int id)
        {
            using (var context = new SoftnessContext())
            {
                var funcionario = new FuncionarioDAO().BuscaPorId(id);
                funcionario.Ativo = false;
                context.Entry(funcionario).State = EntityState.Modified;
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

        public IList<Funcionario> ListaFuncionarios()
        {
            using (var contexto = new SoftnessContext())
            {
                return contexto.Funcionarios.Include(c => c.Pessoa).Where(a => a.Ativo == true).ToList();
            }
        }
    }
}