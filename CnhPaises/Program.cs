using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace CnhPaises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pais brasil = new Pais("Brasil", "BR");
            CNH cnh = new CNH(brasil, 24);

            if (cnh.Pais1 != null)
            {
                if (cnh.Pais1.Sigla == "BR")
                {
                    Console.WriteLine($"A CNH é do pais {cnh.Pais1.Nome} e a idade é {cnh.Idade} e o tipo da carteira é {cnh.Pais1.TipoCarteira}");
                } else
                Console.WriteLine($"O país é {cnh.Pais1.Nome} e a idade é {cnh.Idade}");
            }
            else
            {
                Console.WriteLine("O objeto país é null");
            }
        }
    }
}