using Exercicio_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces
{
    public class Ave : Animal, IOviparo, IVoar, IAquatico
    {
        public bool Rapina { get; set; }
        public string CorPena { get; set; }

        // interface voar
        public int AltitudeMaximaEmMetros {  get; set; }
        public double VelocidadeVoo { get; set; }

        // interface aquatica 

        public bool ViveTerra { get; set; }
        public bool Mergulha { get; set; }
        public bool AguaDoce { get; set; }


        public Ave(bool rapina, string corpena, string nome, DateTime datanascimento, char sexo) : base(nome, datanascimento, sexo)
        {
            Rapina = rapina;
            CorPena = corpena;
        }


    }
}
