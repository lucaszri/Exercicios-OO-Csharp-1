using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteios
{
    public class Sorteio
    {
        List<string> Pessoas = new List<string>();

        public void AdicionarPessoas()
        {
            Console.WriteLine("Adicione um novo nome para a lista: ");
            string pessoaAdd = Console.ReadLine();
            Pessoas.Add(pessoaAdd);
        }

        public void SortearPessoas()
        {
            Random random = new Random();
            int index = random.Next(Pessoas.Count);
            Console.WriteLine(string.Empty);
            Console.WriteLine($"O nome sorteado foi: {Pessoas[index]}"); 
        }
    }
}
