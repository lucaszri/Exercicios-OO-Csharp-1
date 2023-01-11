using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1_modulo3
{
    public class Professor : Pessoa
    {
        public Professor(string nome, int idade) : base(nome, idade)
        { 
        }

        public void Explicar(string assunto)
        {
            Console.WriteLine($"O professor {Nome} está explicando sobre {assunto}");
        }
    }
}
