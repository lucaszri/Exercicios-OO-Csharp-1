namespace Carros
{
    public class Program
    {
        static void Main(string[] args)
        /*
        Crie uma classe Carro que tenha as propriedades: cor, marca, modelo (sedan ou hatch), 
        capacidadeDoTanque (em litros), tipoDeCombustível (gasolina, álcool ou flex) 
        e um método abastecer que respeite o tipo de combustível que o automóvel aceita e a capacidade máxima de litros.
        Além de abastecer o carro, também devemos ter o preço do abastecimento (gasolina = R$ 5,62/L e etanol = R$ 4,16/L)
         */
        {
           Carro carro = new Carro("Vermelho", "Ferrari", "Coupe", 150, "Gasolina");

            carro.Abastecer(carro);
        }
    }
}