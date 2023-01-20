using Exercicio_Interfaces.Animais;
using System.Reflection;

namespace Exercicio_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arara arara = new Arara(false, "azul", "Arara Azul", new DateTime(2010, 1, 1), 'M');
            arara.AltitudeMaximaEmMetros = 200;
            arara.Carnivoro = false;
            arara.Idade();
            arara.Comunicar();

            DisplayPublicProperties(arara);
            Console.WriteLine(String.Empty);
            

            Ornitorrinco ornitorrinco = new Ornitorrinco(0, true, "marrom", "Ornitorrinco Australiano", new DateTime(2015, 6, 10), 'F');
            ornitorrinco.Amamentar();
            ornitorrinco.Botar();
            ornitorrinco.Chocar();
            ornitorrinco.AguaDoce = true;
            ornitorrinco.Comunicar();
            ornitorrinco.Peconhento = true;
            ornitorrinco.ViveTerra = true;
            ornitorrinco.Mergulha = true;


            DisplayPublicProperties(ornitorrinco);

        }

        public static void DisplayPublicProperties(Arara arara)
        {
            PropertyInfo[] properties = arara.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine("Propriedade: {0}, Valor: {1}", property.Name, property.GetValue(arara));
            }
        }

        public static void DisplayPublicProperties(Ornitorrinco ornitorrinco)
        {
            PropertyInfo[] properties = ornitorrinco.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine("Propriedade: {0}, Valor: {1}", property.Name, property.GetValue(ornitorrinco));
            }
        }
    }
}