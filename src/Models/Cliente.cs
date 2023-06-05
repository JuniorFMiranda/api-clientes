using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiClientes.Models
{
    public sealed class Cliente : Pessoa
    {
        public decimal LimiteCredito { get; set; }
    }
}