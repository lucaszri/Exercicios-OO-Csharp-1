namespace Exercício_1_modulo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa orientado a objetos com as seguintes características:

              Uma classe Pessoa, com atributos nome e idade, e métodos Cumprimentar e DizerIdade; 
              Uma classe Aluno derivada da classe Pessoa, com um método IrParaEscola; 
              Uma classe Professor derivada da classe Pessoa, com um método Explicar que recebe como parâmetro um assunto; 
              Na classe principal:

              Crie uma Pessoa e faça ela Cumprimentar e DizerIdade;
              Crie um Aluno de 21 anos, e faça ele IrParaEscola, Cumprimentar e DizerIdade;
              Crie um Professor de 30 anos, e faça ele Cumprimentar, DizerIdade e Explicar sobre um determinado assunto.*/

            Pessoa pessoa = new Pessoa("Lucas", 27);
            Aluno aluno = new Aluno("Luquinhas", 21);
            Professor professor = new Professor("Lucão", 30);

            aluno.IrParaEscola();
            professor.Explicar("POO");
            aluno.Cumprimentar();
            professor.DizerIdade();
           
        }
    }
}