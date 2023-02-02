using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Times
{
    public class Time
    {
        public string Nome { get; set; }
        public string Esporte { get; set; }
        public int Pontos { get; set; }

        public Time(string nome, string esporte)
        {
            Nome = nome;
            Esporte = esporte;
        }

        public void Pontuar(Time time)
        {
            Console.WriteLine("Digite W para VITÓRIA");
            Console.WriteLine("Digite D para EMPATE");
            Console.WriteLine("Digite L para DERROTA");
            string resultado = Console.ReadLine();

            switch (resultado) 
            {
                case "W":
                    time.Pontos += 3;
                    Console.WriteLine("Você venceu, e somou mais 3 pontos");
                    break;
                case "D":
                    time.Pontos += 1;
                    Console.WriteLine("Você empatou, e somou mais 1 ponto");
                    break;
                case "L":
                    Console.WriteLine("Você perdeu, e não somou pontos");
                    break;
                default: 
                    Console.WriteLine("Opção inválida!");
                    break;

            }
        }
    }
}
