using Newtonsoft.Json;

namespace Exercicio_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Dicionario dicionario = new Dicionario("", "");
            Dicionario.CarregarDicionario();

            while (true)
            {
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Adicionar termo");
                Console.WriteLine("2 - Procurar termos");
                Console.WriteLine("3 - Ver dicionário completo");
                Console.WriteLine("4 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        dicionario.DicionarioAdd();
                        break;
                    case 2:
                        dicionario.ProcurarTermos();
                        break;
                    case 3:
                        dicionario.DicionarioCompleto();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}