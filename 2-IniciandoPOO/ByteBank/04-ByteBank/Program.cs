using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoFelipe = new ContaCorrente();

            contaDoFelipe.titular = "Felipe";

            Console.WriteLine(contaDoFelipe.saldo);

            bool resultadoSaque = contaDoFelipe.Sacar(150);

            Console.WriteLine(contaDoFelipe.saldo);
            Console.WriteLine(resultadoSaque);

            contaDoFelipe.Depositar(500);

            Console.WriteLine(contaDoFelipe.saldo);

            ContaCorrente contaDoTadeu = new ContaCorrente();
            contaDoTadeu.titular = "Tadeu";

            bool resultadoTransferencia = contaDoFelipe.Transferir(100, contaDoTadeu);

            Console.WriteLine("Saldo do Tadeu: " + contaDoTadeu.saldo);
            Console.WriteLine("Saldo do Felipe: " + contaDoFelipe.saldo);

            Console.WriteLine(resultadoTransferencia);

            Console.ReadLine();
        }
    }
}
