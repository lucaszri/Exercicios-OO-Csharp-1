namespace BoletimFaculdade
{
    internal class Program

    /*Construa uma classe Boletim para uma faculdade com as propriedades: nome (do aluno), 
    * ano (maior que 1964), semestre(de 1 a 14) e um List com as médias de 6 máterias.*/
    {
        static void Main(string[] args)
        {
            Boletim aluno = new Boletim("lucas", 1990, 5);
            Console.WriteLine(aluno.Ano);

            aluno.Materias.Add("Matematica" , 4.6);
            aluno.Materias.Add("Português", 6.3);
            aluno.Materias.Add("Inglês" , 7.1);
            aluno.Materias.Add("Ed. Física" , 6.0);
            aluno.Materias.Add("Quimica" , 9.6);

            foreach (KeyValuePair<string, double> entry in aluno.Materias)
            {
                Console.WriteLine($"Na matéria {entry.Key}, sua nota foi: {entry.Value}");
            }
        }
    }
}
    