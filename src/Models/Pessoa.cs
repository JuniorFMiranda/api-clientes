using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace ApiClientes.Models
{
    public abstract class Pessoa
    {
        public int Id { get; set;}
        public string Nome { get; set; }
        public string Documento { get; set; }
        public bool Ativo { get; set; }
    }
}