using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros
{
    public class Carro
    {
        public string Cor { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int CapacidadeDoTanqueLitros { get; set; }
        public string TipoDeCombustivel { get; set; }

        public Carro (string cor, string marca, string modelo, int capacidadeDoTanqueLitros, string tipoDeCombustivel)
        {
            this.Cor = cor;
            this.Marca = marca;
            this.Modelo = modelo;
            this.CapacidadeDoTanqueLitros = capacidadeDoTanqueLitros;
            this.TipoDeCombustivel = tipoDeCombustivel;
        }

        public void Abastecer(Carro carro)
        {
            Console.WriteLine("Informe o tipo de combustível que deseja: ");
            string combustivelEscolhido = Console.ReadLine();

            if(combustivelEscolhido != carro.TipoDeCombustivel)
            {
                Console.WriteLine("O tipo de combustível escolhido não é compátivel com esse carro!");
                return;
            }

            Console.WriteLine("Quantos litros você deseja abastecer? Digite o valor abaixo:");
            int litrosEscolhido = int.Parse(Console.ReadLine());

            if(litrosEscolhido > carro.CapacidadeDoTanqueLitros) 
            {
                Console.WriteLine($"Esse carro só suporta {carro.CapacidadeDoTanqueLitros}, não é possível colocar {litrosEscolhido} ");
                return;
            }

            double valorCombustivel = 0;

            if(carro.TipoDeCombustivel == "Etanol")
            {
                valorCombustivel = 4.16;
            } 

            if (carro.TipoDeCombustivel == "Gasolina")
            {
                valorCombustivel = 5.26;
            }

            double valorTotal = litrosEscolhido * valorCombustivel;

            Console.WriteLine($"Você abasteceu {litrosEscolhido} litros, de {combustivelEscolhido}.");
            Console.WriteLine($"O valor foi R$ { valorTotal.ToString("0.00") }");

           
        }
    }
}
