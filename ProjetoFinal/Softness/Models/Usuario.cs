using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Softness.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public Pessoa Pessoa { get; set; }
        public string NomeDeUsuario { get; set; }
        public string Senha { get; set; }
        public string TipoDeAcesso { get; set; }
        public string Cargo { get; set; }
    }
}