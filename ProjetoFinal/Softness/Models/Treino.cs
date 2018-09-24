using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Softness.Models
{
    public class Treino
    {
        public int Id { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }
        public float Imc { get; set; }

        public string Exercicio { get; set; }
        public string Serie { get; set; }
        public string Repeticoes { get; set; }
        public string Carga { get; set; }
        public string Intervalo { get; set; }

        
        //public string TreinosDia {get;set;}
        //public string TreinosRealizados { get; set; }
        //public string Personal { get; set; }
        //public string Categoria { get; set; }
        //public string Complemento { get; set; }
    }
}