namespace BoletimFaculdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boletim aluno = new Boletim("lucas", 1990, 5);
            Console.WriteLine(aluno.Ano);

            aluno.Materias.Add("Matematica" , 4.6);
            aluno.Materias.Add("Português", 6.3);
            aluno.Materias.Add("Ingês" , 7.1);
            aluno.Materias.Add("Ed. Física" , 6.0);
            aluno.Materias.Add("Quimica" , 9.6);

            foreach (KeyValuePair<string, double> entry in aluno.Materias)
            {
                Console.WriteLine($"Na matéria {entry.Key}, sua nota foi: {entry.Value}");
            }
        }
    }
}
    