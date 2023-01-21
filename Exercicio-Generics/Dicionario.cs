using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Generics
{
    public class Dicionario
    {
        public string Term { get; set; }
        public string Definition { get; set; }

        //lista com todos os termos
        public static List<Dicionario> listaDicionario = new List<Dicionario>();

        public Dicionario(string term, string definition)
        {
            Term = term;
            Definition = definition;
        }

        //metodo para adicionar termos/definições a lsita
        public void DicionarioAdd()
        {
            Console.WriteLine("Escreva o termo que deseja adicionar: ");
            string term = Console.ReadLine();
            Console.WriteLine($"Escreva a definição de '{term}': ");
            string definition = Console.ReadLine();

            //criada uma segunda lista para mandar as novas informações para o arquivo json
            Dicionario newDictionary = new Dicionario(term, definition);
            listaDicionario.Add(newDictionary);

            //pegar o caminho do diretorio atual do projeto, no final o nome do arquivo
            string jsonFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dictionary.json");
            // A classe FileStream é usada para ler e gravar dados em arquivos.
            //@jsonfile é o caminho criado na string linha 38
            //FileMode.Open, que indica que o arquivo deve ser aberto para leitura e escrita.
            //FileAccess.ReadWrite, que indica que o arquivo pode ser lido e escrito.
            FileStream fs = new FileStream(@jsonFile, FileMode.Open, FileAccess.ReadWrite);
            string json = "";
            foreach (Dicionario item in listaDicionario)
            {
                //Formatting.Indented identa o json
                json += JsonConvert.SerializeObject(item, Formatting.Indented) + ",";
            }
            /*
            A primeira linha "json = "[" + json.Substring(0, json.Length - 1) + "]";" 
            adiciona o colchete "[" no início e o colchete "]" no final do json.
            A função Substring(0, json.Length - 1) é usada para remover a última vírgula "," na string json, 
            que foi adicionada após cada item serializado na linha "json += JsonConvert.SerializeObject(item, Formatting.Indented) + ",";".
            Assim, o json gerado tem o formato correto, com colchetes no início e no final e sem vírgula adicional no final.

            A segunda linha "byte[] jsonBytes = Encoding.ASCII.GetBytes(json);" 
            cria um array de bytes a partir do json, usando a classe Encoding.ASCII. 
            O método GetBytes converte a string json em um array de bytes, que é armazenado na variável jsonBytes.
            Esse array de bytes é necessário para escrever os dados no arquivo json.

            Ao usar a classe Encoding.ASCII, é garantido que os bytes gerados corresponderão ao conjunto de caracteres ASCII 
            (American Standard Code for Information Interchange), que é amplamente utilizado e suportado em muitos sistemas.
             */
            json = "[" + json.Substring(0, json.Length - 1) + "]";
            byte[] jsonBytes = Encoding.ASCII.GetBytes(json);
            fs.Write(jsonBytes, 0, jsonBytes.Length);
            fs.Close();
        }

        //procurar termos todos os termos que tenham caracteres iguais a var procurarTermo
        public void ProcurarTermos()
        {
            Console.WriteLine("Digite o termo que deseja encontrar: ");
            string procurarTermo = Console.ReadLine();
            bool encontrado = false;
            foreach (Dicionario d in listaDicionario)
            {
                if (d.Term.ToUpper().Contains(procurarTermo.ToUpper()))
                {
                    if (!encontrado)
                    {
                        Console.WriteLine($"A procura por {procurarTermo}, foram encontrados os resultados: ");
                        encontrado = true;
                    }
                    Console.WriteLine($"Termo: {d.Term} - Definição: {d.Definition}");
                }
            }
            if (!encontrado)
            {
                Console.WriteLine($"A procura por {procurarTermo}, não encontrou resultados");
            }
        }
    

        // dicionario completo
        public void DicionarioCompleto()
        {
            foreach (Dicionario d in listaDicionario)
            {
                Console.WriteLine($"Termo: {d.Term} - Definição: {d.Definition}");
            }
        }

        //banco de dados
        //carregar banco de dados
        public static void CarregarDicionario()
        {
            if (File.Exists(@"C:\Users\lucas\source\repos\ExerciciosPOOcs\Exercicio-Generics\bin\Debug\net6.0\dictionary.json"))
            {
                // Read json string from the file
                string json = File.ReadAllText(@"C:\Users\lucas\source\repos\ExerciciosPOOcs\Exercicio-Generics\bin\Debug\net6.0\dictionary.json");

                // Deserialize json string to a list of objects
                listaDicionario = JsonConvert.DeserializeObject<List<Dicionario>>(json);


            }
        }
    }
}
