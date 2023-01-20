using Exercicio_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces.Animais
{
    public class Pinguim : Ave, IAquatico, IOviparo
    {
        //aquatico
        public bool ViveTerra { get; set; }
        public bool Mergulha { get; set; }
        public bool AguaDoce { get; set; }
        public Pinguim(bool rapina, string corpena, string nome, DateTime datanascimento, char sexo)
            : base(rapina, corpena, nome, datanascimento, sexo)
        {

        }
        public override void Comunicar()
        {
            Console.WriteLine($"O {Nome} pipipi (piou)... ");
        }
    }
}
