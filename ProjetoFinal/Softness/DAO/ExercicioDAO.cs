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


        public IList<Exercicio> ListaExercicios()
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

        public void Atualiza(Exercicio exercicio)
        {
            using (var contexto = new SoftnessContext())
            {
                contexto.Exercicios.Update(exercicio);
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