using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Softness.Models
{
    public class Exercicio
    {
        public int Id { get; set; }
        public string ExercicioNome { get; set; }
        public string Series { get; set; }
        public string Repeticoes { get; set; }
        public string Carga { get; set; }
        public string Intervalo { get; set; }
        public Treino Treino { get; set; }
        public int? TreinoId { get; set; }
    }
}