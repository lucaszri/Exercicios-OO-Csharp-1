using Exercicio_Interfaces.Classes;
using Exercicio_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces.Animais
{
    public class Lontra : Mamifero, IAquatico
    {
        //aquatico
        public bool ViveTerra { get; set; }
        public bool Mergulha { get; set; }
        public bool AguaDoce { get; set; }
        public Lontra(int quantidademamas, bool pelos, string corpelo, string nome, DateTime datanascimento, char sexo) :
            base(quantidademamas, pelos, corpelo, nome, datanascimento, sexo)
        {

        }
        public override void Comunicar()
        {
            Console.WriteLine($"A {Nome} miiii (cantou)... ");
        }
    }
}
