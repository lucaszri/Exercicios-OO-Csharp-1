using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CnhPaises
{
    public class Pais
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public string TipoCarteira { get; set; }

        public Pais(string nome, string sigla) 
        {
            Nome = nome;
            Sigla = sigla;
            if (sigla == "BR") 
            {
                TipoCarteira = PedirTipo();
            }
        }

        public string PedirTipo()
        {
            Console.WriteLine("Informe o tipo da carteira (A, B, C, D, E, AB, AC, AD ou AE): ");
            string tipoCarteira = Console.ReadLine();
            return tipoCarteira;
        }
 
    }
}

