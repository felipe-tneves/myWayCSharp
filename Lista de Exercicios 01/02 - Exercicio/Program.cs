using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 – Crie um algoritmo que calcule a área de um retângulo.

            Console.WriteLine("Exercicio 02");

            double result;

            Console.WriteLine("Informe a altura do retângulo: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a largura do retângulo: ");
            double largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número para a opção de calculo: ");
            Console.WriteLine("1 - Area;\n" +
                "2 - Perimetro\n" +
                "0 - Sair");
            int escolha = Int32.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    result = altura * largura;
                    Console.WriteLine("O resultado da área é: " + result);
                    break;

                case 2:
                    result = (2 * altura) + (2 * largura);
                    Console.WriteLine("O resultado do perimetro é: " + result);
                    break;

                default:
                    break;
            }


            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
