using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeTadeu = 23;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
                mensagemAdicional = "Tadeu está acompanhado";
            
            else
               mensagemAdicional = "Tadeu não está acompanhado";
            

            if (idadeTadeu >= 18 || acompanhado == true)
            {
                Console.WriteLine("Tadeu pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Tadeu não pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }

            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
