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
                context.Clientes.Add(cliente);
                context.SaveChanges();
            }
        }

        public IList<Cliente> Lista()
        {
            using (var contexto = new SoftnessContext())
            {
                return contexto.Clientes.ToList();
                //return contexto.Clientes.Include("Pessoa").ToList();
            }
        }

        public Cliente BuscaPorId(int id)
        {
            using (var contexto = new SoftnessContext())
            {
                return contexto.Clientes.Find(id);
            }
        }

        public void Atualiza(Cliente Clientes)
        {
            using (var contexto = new SoftnessContext())
            {
                contexto.Entry(Clientes).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Remover(Cliente cliente)
        {
            using (var context = new SoftnessContext())
            {
                context.Clientes.Remove(cliente);
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