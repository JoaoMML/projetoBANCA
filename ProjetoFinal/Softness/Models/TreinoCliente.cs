using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Softness.Models
{
    public class TreinoCliente
    {
        public int Id { get; set; }
        public Treino Treino { get; set; }
        public int TreinoId {get;set;} 
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public char TipoTreino { get; set; }
    }
}