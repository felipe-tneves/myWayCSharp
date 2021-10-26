using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoTadeu = new ContaCorrente();

            contaDoTadeu.titular = "Tadeu";
            contaDoTadeu.agencia = 832;
            contaDoTadeu.numero = 123456;
            contaDoTadeu.saldo = 100;


            Console.WriteLine(contaDoTadeu.titular);
            Console.WriteLine("Agência: " + contaDoTadeu.agencia);
            Console.WriteLine("Número: " + contaDoTadeu.numero);
            Console.WriteLine("Saldo: R$" + contaDoTadeu.saldo);

            contaDoTadeu.saldo += 200; ;

            Console.WriteLine("Saldo: R$" + contaDoTadeu.saldo);

            Console.ReadLine();

        }
    }
}
