using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 86712540);

            Console.WriteLine(conta.Numero);
            Console.WriteLine(conta.Agencia);

            ContaCorrente contaDoFelipe = new ContaCorrente(867, 86712345);

            //Console.WriteLine(ContaCorrente.ObterTotalDeContasCriadas());
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
