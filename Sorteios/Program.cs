namespace Sorteios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sorteio sorteio = new Sorteio();

            sorteio.AdicionarPessoas();
            sorteio.AdicionarPessoas();
            sorteio.AdicionarPessoas();
            sorteio.AdicionarPessoas();

            sorteio.SortearPessoas();
        }
    }
}