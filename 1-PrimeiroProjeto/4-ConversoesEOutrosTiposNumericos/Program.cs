using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;
            Console.WriteLine(salario);

            //int é um tipo de variavel de 32 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            //int = long 
            //long é um tipo de variavel de 64bits
            long idade = 130000000000;
            Console.WriteLine(idade);

            //shot é um tipo de variavel de 16bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            //como não é muito usual usar float tem que colocar f para identificar ele 
            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
