using Microsoft.EntityFrameworkCore;
using Softness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Softness.DAO
{
    public class TreinosDAO
    {
        public void Adiciona(Treino treino)
        {
            using (var context = new SoftnessContext())
            {
                context.Treinos.Add(treino);
                context.SaveChanges();
            }
        }

        public IList<Treino> Lista()
        {
            using (var contexto = new SoftnessContext())
            {
                return contexto.Treinos.ToList();
            }
        }

        public Treino BuscaPorId(int id)
        {
            using (var contexto = new SoftnessContext())
            {
                return contexto.Treinos.Find(id);
            }
        }

        public void Atualiza(Treino Treinos)
        {
            using (var contexto = new SoftnessContext())
            {
                contexto.Entry(Treinos).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Remover(Treino treino)
        {
            using (var context = new SoftnessContext())
            {
                context.Treinos.Remove(treino);
                context.SaveChanges();
            }
        }
    }
}