using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Softness.Models
{
    public class ExercicioTreino
    {
        public int Id { get; set; }
        public Exercicio Exercicio{ get; set; }
        public int ExercicioId { get; set; }
        public Treino Treino { get; set; }
        public int TreinoId { get; set; }
    }
}