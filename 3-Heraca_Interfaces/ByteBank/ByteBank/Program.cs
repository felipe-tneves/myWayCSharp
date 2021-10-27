using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();



            Funcionario tadeu = new Funcionario();

            tadeu.Nome = "Tadeu";
            tadeu.CPF = "546.879.157-20";
            tadeu.Salario = 3400;

            gerenciador.Registrar(tadeu);

            
            Diretor felipe = new Diretor();

            felipe.Nome = "Felipe";
            felipe.CPF = "454.585.159-30";
            felipe.Salario = 10000;

            gerenciador.Registrar(felipe);

            Console.WriteLine(tadeu.Nome);
            Console.WriteLine(tadeu.GetBonificacao());

            Console.WriteLine(felipe.Nome);
            Console.WriteLine(felipe.GetBonificacao());

            Console.WriteLine("Total de bonificações:" + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
