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

        public Exercicio BuscaPorId(int id)
        {
            using (var contexto = new SoftnessContext())
            {
                return contexto.Exercicios.Find(id);
            }
        }

        public void Atualiza(Exercicio exercicio)
        {
            using (var contexto = new SoftnessContext())
            {
                contexto.Exercicios.Update(exercicio);
                contexto.SaveChanges();
            }
        }

        public void Remover(int id)
        {
            using (var context = new SoftnessContext())
            {
                var exercicio = new ExercicioDAO().BuscaPorId(id);
                context.Entry(exercicio).State = EntityState.Modified;
                context.SaveChanges();
            }
        }


        public IList<Exercicio> ListaExercicios()
        {
            using (var contexto = new SoftnessContext())
            {
                return contexto.Exercicios.ToList();
            }
        }
    }
}