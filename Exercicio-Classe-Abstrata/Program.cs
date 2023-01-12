namespace Exercicio_Classe_Abstrata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motorola motorola = new Motorola("(11)910102020", "G50", "483290483248", 6);
            Iphone iphone = new Iphone("(12)981812020", "Iphone 13", "482390489023", 8);

            motorola.Ligar();
            motorola.InstalarAplicativo("");

            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("");
        }
    }
}