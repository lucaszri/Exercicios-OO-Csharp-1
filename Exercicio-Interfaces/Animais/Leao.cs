using Exercicio_Interfaces.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces.Animais
{
    public class Leao : Mamifero
    {
        public Leao(int quantidademamas, bool pelos, string corpelo, string nome, DateTime datanascimento, char sexo) :
            base(quantidademamas, pelos, corpelo, nome, datanascimento, sexo)
        {

        }
        public override void Comunicar()
        {
            Console.WriteLine($"O {Nome} rwahhh (rugiu)... ");
        }
    }
}
