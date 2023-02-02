namespace Restaurante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Lucas", "Londres");
            Restaurante restaurante = new Restaurante("Londres", true, 13);

            restaurante.EntregarPedido(pessoa);
        }
    }
}