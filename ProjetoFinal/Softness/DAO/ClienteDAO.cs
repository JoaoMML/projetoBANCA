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

        public Cliente BuscaPorId(int id)
        {
            using (var contexto = new SoftnessContext())
            {
                return contexto.Clientes.Include(p => p.Pessoa).ThenInclude(e => e.Endereco).Where(i => i.Id == id).FirstOrDefault();
            }
        }

        public void Atualiza(Cliente cliente)
        {
            using (var contexto = new SoftnessContext())
            {
                contexto.Clientes.Update(cliente);
                contexto.SaveChanges();
            }
        }

        public void Remover(int id)
        {
            using (var context = new SoftnessContext())
            {
                var cliente = new ClienteDAO().BuscaPorId(id);
                cliente.Ativo = false;
                context.Entry(cliente).State = EntityState.Modified;
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

        public IList<Cliente> ListaClientes()
        {
            using (var contexto = new SoftnessContext())
            {
                return contexto.Clientes.Include(c => c.Pessoa).Where(a => a.Ativo == true).ToList();
            }
        }
    }
}