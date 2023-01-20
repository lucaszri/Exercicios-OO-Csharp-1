using Exercicio_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces
{
    public class Ave : Animal
    {
        public bool Rapina { get; set; }
        public string CorPena { get; set; }

        public Ave(bool rapina, string corpena, string nome, DateTime datanascimento, char sexo) : base(nome, datanascimento, sexo)
        {
            Rapina = rapina;
            CorPena = corpena;
        }


    }
}
