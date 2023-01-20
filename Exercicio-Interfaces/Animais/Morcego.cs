using Exercicio_Interfaces.Classes;
using Exercicio_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces.Animais
{
    public class Morcego : Mamifero, IVoar
    {
        //voar
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeVoo { get; set; }
        public Morcego(int quantidademamas, bool pelos, string corpelo, string nome, DateTime datanascimento, char sexo) :
            base(quantidademamas, pelos, corpelo, nome, datanascimento, sexo)
        {

        }
        public override void Comunicar()
        {
            Console.WriteLine($"O {Nome} ti ti ti ti ti (farfalhou)... ");
        }
    }
}
