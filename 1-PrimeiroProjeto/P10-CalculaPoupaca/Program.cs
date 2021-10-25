using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupaca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após "+ contadorMes +"  mês, você terá R$ " + valorInvestido + "\n");
                contadorMes++;
            }

            //0.36% = 0.0036
            //valorInvestido = valorInvestido + valorInvestido * 0.0036;
            //Console.WriteLine("Após 1 mês, você terá R$ " + valorInvestido);

            //valorInvestido = valorInvestido + valorInvestido * 0.0036;
            //Console.WriteLine("Após 2 mês, você terá R$ " + valorInvestido);

            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
