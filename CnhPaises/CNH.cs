using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnhPaises
{
    public class CNH
    {
        public int Idade;
        public Pais Pais1;

        
        public CNH(Pais pais, int idade)
        {
            Pais1 = pais;
            Idade = idade;
            if(idade < 18) { 
                if(pais.Sigla == "US" || pais.Sigla == "CA")
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
                if(pais.Sigla == "CH" || pais.Sigla == "RU")
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
