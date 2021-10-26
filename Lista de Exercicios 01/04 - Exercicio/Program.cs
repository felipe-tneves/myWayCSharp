using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //4- Crie um algoritmo que verifique se um número informado é par ou impar
            Console.WriteLine("Exercicio 04");

            Console.WriteLine("Digite um numero: ");
            double numero = double.Parse(Console.ReadLine());

            if (numero%2 ==0)
            {
                Console.WriteLine("O número informado é par");
            }
            else
            {
                Console.WriteLine("O número informado é impar");
            }

            Console.WriteLine("Tecle enter para sair");
            Console.ReadLine();
        }
    }
}
