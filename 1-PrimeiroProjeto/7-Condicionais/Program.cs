using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeTadeu = 15;
            int quantidadeDePessoas = 1;

            if (idadeTadeu >= 18)
            {
                Console.WriteLine("Tadeu possui mais de 18 anos. Pode entrar.");
            }
            else
            {
                if (quantidadeDePessoas >= 2)
                {
                    Console.WriteLine("Tadeu não possui mais de 18 anos, mas está acompanhado. Pode entrar");
                }
                else
                {
                    Console.WriteLine("Tadeu não possui mais de 18, não pode entrar.");
                }
            }

            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
