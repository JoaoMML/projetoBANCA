using Microsoft.EntityFrameworkCore;
using Softness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Softness.DAO
{
    public class FichaTreinoDAO
    {
        public void Adiciona(FichaTreino ficha)
        {
            using (var context = new SoftnessContext())
            {
                context.FichaTreinos.Add(ficha);
                context.SaveChanges();
            }
        }

        public IList<FichaTreino> Lista()
        {
            using (var contexto = new SoftnessContext())
            {
                return contexto.FichaTreinos.ToList();
            }
        }

        public FichaTreino BuscaPorId(int id)
        {
            using (var contexto = new SoftnessContext())
            {
                return contexto.FichaTreinos.Find(id);
            }
        }

        public void Atualiza(FichaTreino FichaTreinos)
        {
            using (var contexto = new SoftnessContext())
            {
                contexto.Entry(FichaTreinos).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Remover(FichaTreino ficha)
        {
            using (var context = new SoftnessContext())
            {
                context.FichaTreinos.Remove(ficha);
                context.SaveChanges();
            }
        }
    }
}