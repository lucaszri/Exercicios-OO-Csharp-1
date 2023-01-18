using Exercicio_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces.Classes
{
    public class Reptil : Animal, IOviparo, IAquatico
    {
        public bool Escamas { get; set; }
        public bool Casco { get; set; }

        // interface aquatica 
        public bool ViveTerra { get; set; }
        public bool Mergulha { get; set; }
        public bool AguaDoce { get; set; }

        public Reptil(bool escamas, bool casco, string nome, DateTime datanascimento, char sexo) : base(nome, datanascimento, sexo)
        {
            Escamas = escamas;
            Casco = casco;
        }
    }
}
