using Exercicio_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces.Animais
{
    public class Coruja : Ave, IOviparo, IVoar
    {
        //voar
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeVoo { get; set; }
        public Coruja(bool rapina, string corpena, string nome, DateTime datanascimento, char sexo)
            : base(rapina, corpena, nome, datanascimento, sexo)
        {

        }
        public override void Comunicar()
        {
            Console.WriteLine($"A {Nome} uh uh uh (piou)... ");
        }
    }
}
