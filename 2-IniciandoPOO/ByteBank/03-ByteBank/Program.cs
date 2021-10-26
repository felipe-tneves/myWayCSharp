using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipos de Referencia
            ContaCorrente contaDoTadeu = new ContaCorrente();
            contaDoTadeu.titular = "Tadeu";
            contaDoTadeu.agencia = 863;
            contaDoTadeu.numero = 863452;

            ContaCorrente contaDoTadeuFelipe = new ContaCorrente();
            contaDoTadeuFelipe.titular = "Tadeu";
            contaDoTadeuFelipe.agencia = 863;
            contaDoTadeuFelipe.numero = 863452;

            Console.WriteLine(contaDoTadeu == contaDoTadeuFelipe);

            //Tipos de valores 
            int idade = 23;
            int idadeMaisUmaVez = 23;

            Console.WriteLine(idade == idadeMaisUmaVez);

            //Colocando uma referencia na outra 
            contaDoTadeu = contaDoTadeuFelipe;
            Console.WriteLine(contaDoTadeu == contaDoTadeuFelipe);


            contaDoTadeu.saldo = 300;
            Console.WriteLine(contaDoTadeu.saldo);
            Console.WriteLine(contaDoTadeuFelipe.saldo);

            if (contaDoTadeu.saldo >= 100)
            {
                contaDoTadeu.saldo -= 100;
            }


            Console.ReadLine();
        }
    }
}
