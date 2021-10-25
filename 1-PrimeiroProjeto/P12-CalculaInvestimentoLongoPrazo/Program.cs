using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 12");


            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            //for encadeado
            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 0; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }

                fatorRendimento += 0.0010;
            }

            //Console.WriteLine("Tempo de investimento foi de " + contadorAno);
            Console.WriteLine("Ao término do investimento, você terá R$ " + valorInvestido);

            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
