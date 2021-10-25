using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 05 - Caractes e textos");

            //character
            char primeiraLetra = 'a';

            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;

            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);

            Console.WriteLine(primeiraLetra);

            string nome = "Felipe Tadeu Neves Santos " + 2021;
            Console.WriteLine(nome);

            string cursos = "- .NET\n" +
                "- Node.js\n" +
                "- SQL";

            Console.WriteLine(cursos);

            Console.WriteLine("Tecla enter para sair...");
            Console.ReadLine();
        }
    }
}
