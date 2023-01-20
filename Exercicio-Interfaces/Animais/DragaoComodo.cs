using Exercicio_Interfaces.Classes;
using Exercicio_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces.Animais
{
    public class DragaoComodo : Reptil, IOviparo
    {
        public DragaoComodo(bool escamas,bool casco,string nome,DateTime datanascimento,char sexo) 
            : base(escamas, casco, nome, datanascimento, sexo)
        {

        }
        public override void Comunicar()
        {
            Console.WriteLine($"O {Nome} rwahhh (rugiu)... ");
        }
    }
}
