using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1_modulo3
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public Pessoa(string nome, int idade) 
        {
            Nome = nome;
            Idade = idade;
        }

        public string Cumprimentar()
        {
            string texto = $" {Nome} comprimentou";
            return texto ;
        }

        public void DizerIdade()
        {
            Console.WriteLine($"{Nome} falou que sua idade é {Idade}" );
        }


    }
}
