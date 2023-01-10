namespace CnhPaises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CNH cnh = new CNH("BR", 63);

            Console.WriteLine($"O pais {cnh.Pais} e a idade {cnh.Idade}");
        }
    }
}