using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces.Classes
{
    public class Mamifero : Animal
    {
        public int QuantidadeMamas { get; set; }
        public bool Pelos { get; set; }
        public string CorPelo { get; set; }

        public Mamifero(int quantidademamas, bool pelos, string corpelo, string nome, DateTime datanascimento, char sexo) : base(nome, datanascimento, sexo)
        {
            QuantidadeMamas = quantidademamas;
            Pelos = pelos;
            CorPelo = corpelo;
        }

        public void Amamentar()
        {
            Console.WriteLine($"O {Nome} alimentou... ");
        }
    }
}
