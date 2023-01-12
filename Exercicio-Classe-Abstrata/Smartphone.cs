using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Classe_Abstrata
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public Smartphone (string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Você abriu o modo discagem, digite o número desejado: ");
            long numeroLigacao = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"Você está ligando para o número {numeroLigacao}");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Você está recebendo uma ligação...");
            Console.WriteLine("Deseja atender? Digite a tecla: (s) para sim ou (n) para não ");
            string escolha = Console.ReadLine();

            switch(escolha)
            {
                case "s":
                    Console.WriteLine("Ligação atendida!");
                    break;
                case "n":
                    Console.WriteLine("Ligação rejeitada!");
                    break;
                default:
                    Console.WriteLine("Opção incorreta, para realizar a ação tecle s/n");
                    break;
            }
            
        }
        public virtual void InstalarAplicativo(string nome)
        {
            Console.WriteLine("Digite o nome do aplicativo que você quer baixar: ");
            string aplicativo = Console.ReadLine();
            nome = aplicativo;
            Console.WriteLine($"Você baixou o app {nome}!");
        }

    }
}
