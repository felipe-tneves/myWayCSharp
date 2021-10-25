using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 – Crie um algoritmo que exiba a tabuada de um número.
            Console.WriteLine("Executando o exercicio 01");

            //1 X 2 = 2

            //int valorDaTaboada = 9;
            int result;

            Console.WriteLine("Digite o valor para ver a taboada: ");
            int valorDaTaboada = Int32.Parse(Console.ReadLine());


            for (int i = 1; i <= 10; i++)
            {
                result = i * valorDaTaboada;
                Console.WriteLine(i + " X " + valorDaTaboada + " = " + result);
            }


            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
