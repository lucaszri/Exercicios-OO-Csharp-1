using Exercicio_Interfaces.Classes;
using Exercicio_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces.Animais
{
    public class Jacare : Reptil, IAquatico, IOviparo
    {
        //aquatico
        public bool ViveTerra { get; set; }
        public bool Mergulha { get; set; }
        public bool AguaDoce { get; set; }
        public Jacare(bool escamas, bool casco, string nome, DateTime datanascimento, char sexo)
            : base(escamas, casco, nome, datanascimento, sexo)
        {

        }
        public override void Comunicar()
        {
            Console.WriteLine($"O {Nome} roooor (bramiu)... ");
        }
    }
}
