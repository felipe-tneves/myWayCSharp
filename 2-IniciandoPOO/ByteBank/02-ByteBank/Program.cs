﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Felipe";

            Console.WriteLine("Titular: " + conta.titular);
            Console.WriteLine(conta.agencia);
            Console.WriteLine(conta.saldo);


            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
