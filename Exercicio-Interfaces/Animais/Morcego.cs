﻿using Exercicio_Interfaces.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces.Animais
{
    public class Morcego : Mamifero
    {
        public Morcego(int quantidademamas, bool pelos, string corpelo, string nome, DateTime datanascimento, char sexo) :
            base(quantidademamas, pelos, corpelo, nome, datanascimento, sexo)
        {

        }
    }
}
