using Exercicio_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces.Animais
{
    public class Cisne : Ave, IAquatico, IVoar, IOviparo
    {
        //voar
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeVoo { get; set; }
        //aquatico
        public bool ViveTerra { get; set; }
        public bool Mergulha { get; set; }
        public bool AguaDoce { get; set; }
        public Cisne(bool rapina, string corpena, string nome, DateTime datanascimento, char sexo)
            : base(rapina, corpena, nome, datanascimento, sexo)
        {

        }
        public override void Comunicar()
        {
            Console.WriteLine($"O {Nome} ahn ahn ahn (cantou)... ");
        }
    }
}
