using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //3 – Crie um algoritmo que calcule calcule a média de 5 números.

            Console.WriteLine("Exercicio 03");

            double media, num;

            Console.WriteLine("Digite a quantidade de números que quer fazer a média: ");
            int qtd = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine("Digite o " + i + " :");
                num = double.Parse(Console.ReadLine());
                num += num;
                if (i == qtd)
                {
                    media = num / qtd;
                    Console.WriteLine("A média dos " + qtd + " números digitados é: " + media);
                    break;
                }
            }



            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
