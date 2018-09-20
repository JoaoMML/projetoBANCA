using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Softness.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public Pessoa Pessoa { get; set; }
        public string NomeUsuario { get; set; }
        public string senha { get; set; }
    }
}