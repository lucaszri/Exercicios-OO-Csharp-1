using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnhPaises
{
    public class CNH
    {
        public string Pais;
        public int Idade;

        public CNH(string pais, int idade)
        {
            Pais = pais;
            Idade = idade;
            if(idade < 18) { 
                if(pais == "US" || pais == "CA")
                {
                    if(idade < 16)
                    {
                        Console.WriteLine("Nos países US e CA idade mínima é 16 anos.");
                        Idade = idade;
                        
                    } else
                    {
                        Idade = idade;   
                    }
                }    
                if(pais == "CH" || pais == "RU")
                {
                    if(idade < 21)
                    {
                        Console.WriteLine("Nos países CH e RU, idade mínima é 21 anos");
                        Idade = idade;
                    } else
                    {
                        Idade = idade;
                    }
                }
                Console.WriteLine("Nesse país é necessário ter 18 anos ou mais para adquirir CNH");
            } 
        }
    }
}
