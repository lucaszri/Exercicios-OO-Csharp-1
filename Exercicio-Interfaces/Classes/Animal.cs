using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces
{
    public class Animal
    {
        public string Nome { get; set; }
        DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public bool Carnivoro { get; set; }
        public bool Peconhento { get; set; }

        public Animal(string nome, DateTime datanascimento, char sexo)
        {
            Nome = nome;
            DataNascimento = datanascimento;
            Sexo = sexo;
        }

       
        public void Idade()
            {
            TimeSpan diferenca = DateTime.Now - DataNascimento;
            int anos = (int)diferenca.TotalDays / 365;
            Console.WriteLine($"{Nome} tem {anos} anos");
        }
            
            public virtual void Movimentar()
        {
            Console.WriteLine($"O {Nome} ...");
        }

            public virtual void Comunicar()
        {
            Console.WriteLine($"O {Nome} ... ");
        }

            public void Alimentar()
        {
            Console.WriteLine($"O {Nome} se alimentou...");
        }


    }
}
