using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimFaculdade
{
    public class Boletim
    {
        //nome do aluno
        public string Nome { get; set; }
        
        // tem que iniciar em 1964
        public int Ano { get; set; }

        // 1 ao 14
        public int Semestre { get; set; }

        public Dictionary<string, double> Materias = new Dictionary<string, double>();

        public Boletim(string nome, int ano, int semestre)
        {
            this.Nome = nome;
                if(ano < 1964 || ano > 2023)
                {
                    Console.WriteLine("Ano inválido! Ele tem que ser maior que 1964 e menor que o atual.");
                } else
                {
                    this.Ano = ano;
                }
                if (semestre < 1 || semestre > 14)
                {
                    Console.WriteLine("Número do semestre inválido, ele deve ser entre 1 e 14.");
                }
                else
                {
                    this.Semestre = semestre;
                }
        }
    }
}
