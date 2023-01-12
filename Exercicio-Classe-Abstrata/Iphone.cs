using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Classe_Abstrata
{
    public class Iphone : Smartphone  
    {
        public Iphone(string Numero, string Modelo, string IMEI, int Memoria) : base(Numero, Modelo, IMEI, Memoria)
        {

        }
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine("Bem vindo a AppleStore!");
            base.InstalarAplicativo(nome);
        }
    }   
}
