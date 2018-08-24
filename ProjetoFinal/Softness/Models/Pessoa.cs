using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Softness.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public char Genero { get; set; }
        public string EstadoCivil { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
        public string Email { get; set; }
        public string Fone { get; set; }
        public string Fone2 { get; set; }
    }
}