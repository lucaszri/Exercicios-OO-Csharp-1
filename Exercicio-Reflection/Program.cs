using System.Reflection;

namespace Exercicio_Reflection
{
    public class Program
    {
        static void Main(string[] args)
        {
           Student student = new Student();

            student.Name = "Test";
            student.University = "MOT";
            student.RollNumber = 1;

            Student student1 = CreateInstance("Joao batata", "USP", 123456);
            DisplayPublicProperties(student);
            Console.WriteLine(String.Empty);
            DisplayPublicProperties(student1);
        }

        public static void DisplayPublicProperties(Student student)
        {
            PropertyInfo[] properties = student.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine("Nome: {0}, Valor: {1}", property.Name, property.GetValue(student));
            }
        }

        public static Student CreateInstance(string name, string university, int rollnumber)
        {
            Student student = (Student)Activator.CreateInstance(typeof(Student));

            student.GetType().GetProperty("Name").SetValue(student, name);
            student.GetType().GetProperty("University").SetValue(student, university);
            student.GetType().GetProperty("RollNumber").SetValue(student, rollnumber);

            return student;
        }
    }
}