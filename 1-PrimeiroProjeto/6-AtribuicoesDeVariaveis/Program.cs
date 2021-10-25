using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 06");

            int idade = 23;
            int idadeTadeu = idade;

            idade = 20;
            
            Console.WriteLine(idade);
            Console.WriteLine(idadeTadeu);


            Console.WriteLine("Tecle enter para sair..");
            Console.ReadLine();
        }
    }
}
