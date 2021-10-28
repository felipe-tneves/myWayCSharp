using ByteBank.Funcionarios;
using ByteBank.Sistemas;
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

            CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor tadeu = new Diretor(5000, "159.753.398-04");
            tadeu.Nome = "Tadeu";
            tadeu.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta(3000, "326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(tadeu, "123");
            sistemaInterno.Logar(camila, "abc");
            sistemaInterno.Logar(parceiro, "123456");
        }


        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            //Funcionario do tipo abstract pois ele compartilha as informações 
            //Funcionario carlos = new Funcionario(2000, "456.123456");
            //carlos.GetBonificacao();

            Funcionario matheus = new Designer(2000, "833.222.048-39");
            matheus.Nome = "Matheus";

            Funcionario tadeu = new Diretor(5000, "159.753.398-04");
            tadeu.Nome = "Tadeu";

            Auxiliar victor = new Auxiliar(1000, "981.198.778-53");
            victor.Nome = "Victor";

            GerenteDeConta camila = new GerenteDeConta(3000, "326.985.628-89");
            camila.Nome = "Camila";

            Desenvolvedor felipe = new Desenvolvedor(3400, "456.175.498-59");
            felipe.Nome = "Felipe";

            gerenciadorBonificacao.Registrar(matheus);
            gerenciadorBonificacao.Registrar(tadeu);
            gerenciadorBonificacao.Registrar(victor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(felipe);

            Console.WriteLine("Total de bonificação do mês " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}

