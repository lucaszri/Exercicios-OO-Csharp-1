using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces.Animais
{
    public class Coruja : Ave
    {
        public Coruja(bool rapina, string corpena, string nome, DateTime datanascimento, char sexo)
            : base(rapina, corpena, nome, datanascimento, sexo)
        {

        }
    }
}
