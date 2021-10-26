using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente tadeu = new Cliente();

            //tadeu.nome = "Tadeu";
            //tadeu.profissao = "Desenvolvedor";
            //tadeu.cpf = "404.200.500-30";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = tadeu;
            //criando uma nova instancia de um cliente 
            //conta.titular = new Cliente();
            //conta.titular.nome = "Felipe Tadeu";
            //conta.titular.profissao = "Desenvolvedor";
            //conta.titular.cpf = "404.200.500-30";


            if (conta.titular == null)
            {
                Console.WriteLine("Ops, a referência em conta.titular é null");
            }


            //Console.WriteLine(tadeu.nome);
            //Console.WriteLine(conta.titular.nome);
            //Console.WriteLine(conta.titular.profissao);
            //Console.WriteLine(conta.titular.cpf);

            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 56345727;


            //Console.WriteLine(tadeu.nome);
            //Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.saldo);
            Console.WriteLine(conta.titular);

            Console.ReadLine();
        }
    }
}
