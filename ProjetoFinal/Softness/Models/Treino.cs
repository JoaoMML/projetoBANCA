using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Softness.Models
{
    public class Treino
    {
        public int Id { get; set; }
        public string NomeTreino { get; set; }
        public FichaTreino FichaTreino { get; set; }
        public  int? FichaTreinoId { get; set; }

    }
   
}