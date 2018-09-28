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
                return contexto.Clientes.Include("Pessoa").ToList();
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

        public Cliente Busca(string login, string senha)
        {
            using (var soft = new SoftnessContext())
            {
                return soft.Clientes.Include(f => f.Pessoa).FirstOrDefault(f => f.NomeUsuario == login && f.Senha == senha);
            }
        }
    }
}