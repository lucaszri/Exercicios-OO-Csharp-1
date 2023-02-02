using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Cidade { get; set; }

        public Pessoa(string nome, string cidade) 
        {
            this.Nome = nome;
            this.Cidade = cidade;
        }
    }
}
