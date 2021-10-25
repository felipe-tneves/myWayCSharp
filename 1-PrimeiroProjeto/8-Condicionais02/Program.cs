using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais2");

            int idadeTadeu = 23;
            //int quantidadeDePessoas = 2;
            //bool acompanhado = quantidadeDePessoas >= 2;

            bool acompanhado = false;

            //if (idadeTadeu >= 18 || quantidadeDePessoas >= 2)
            //{
            //    Console.WriteLine("Tadeu pode entrar.");
            //}
            if (idadeTadeu >= 18 && acompanhado == true)
            {
                Console.WriteLine("Tadeu pode entrar.");
            }
            else
            {
                Console.WriteLine("Tadeu não pode entrar.");
            }

            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
