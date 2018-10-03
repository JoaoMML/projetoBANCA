using Microsoft.EntityFrameworkCore;
using Softness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Softness.DAO
{
    public class ExercicioDAO
    {
        public void Adiciona(Exercicio exercicio)
        {
            using (var context = new SoftnessContext())
            {
                context.Exercicios.Add(exercicio);
                context.SaveChanges();
            }
        }

        public IList<Exercicio> Lista()
        {
            using (var contexto = new SoftnessContext())
            {
                return contexto.Exercicios.ToList();
            }
        }

        public Exercicio BuscaPorId(int id)
        {
            using (var contexto = new SoftnessContext())
            {
                return contexto.Exercicios.Find(id);
            }
        }

        public void Atualiza(Exercicio Exercicios)
        {
            using (var contexto = new SoftnessContext())
            {
                contexto.Entry(Exercicios).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Remover(Exercicio exercicio)
        {
            using (var context = new SoftnessContext())
            {
                context.Exercicios.Remove(exercicio);
                context.SaveChanges();
            }
        }
    }
}