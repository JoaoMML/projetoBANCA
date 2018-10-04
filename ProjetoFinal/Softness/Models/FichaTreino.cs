using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Softness.Models
{
    public class FichaTreino
    {
        public int Id { get; set; }
        public string NomeFicha { get; set; }
        public string Professor { get; set; }
        public DateTime DataInicio { get; set; }
        public string TipoDuracao { get; set; }
        public string Frequencia { get; set; }
        public string Observacoes { get; set; }
        public Cliente Cliente { get; set; }
        public int? ClienteId { get; set; }
    }
}