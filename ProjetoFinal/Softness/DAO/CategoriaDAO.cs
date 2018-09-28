using Microsoft.EntityFrameworkCore;
using Softness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Softness.DAO
{
    public class CategoriaDAO
    {
        public void Adiciona(CategoriaDoProduto categoria)
        {
            using (var context = new SoftnessContext())
            {
                context.Categorias.Add(categoria);
                context.SaveChanges();
            }
        }

        public IList<CategoriaDoProduto> Lista()
        {
            using (var contexto = new SoftnessContext())
            {
                return contexto.Categorias.ToList();
            }
        }

        public CategoriaDoProduto BuscaPorId(int id)
        {
            using (var contexto = new SoftnessContext())
            {
                return contexto.Categorias.Find(id);
            }
        }

        public void Atualiza(CategoriaDoProduto categoria)
        {
            using (var contexto = new SoftnessContext())
            {
                contexto.Entry(categoria).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}