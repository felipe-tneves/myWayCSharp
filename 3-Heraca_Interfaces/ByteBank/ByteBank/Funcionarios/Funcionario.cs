using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        //0 - funcionário
        //1 - diretor
        //2 - designer
        //3 - Gerente de conta corrente
        //4 - coordenador
        //private int _tipo;

        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        //public Funcionario(int tipo)
        //{
        //    _tipo = tipo;
        //}

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando Funcionario\n");
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        //public virtual void AumentarSalario()
        //{
        //    //Salario = Salario + (Salario * 0.1);
        //    //Salario = Salario * 1.1;
        //    Salario *= 1.1;
        //}

        //public virtual double GetBonificacao()
        //{
        //    //if (_tipo == 1)
        //    //    return Salario;

        //    return Salario * 0.10;
        //}

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();


    }
}


//public class Base
//{
//    public virtual void M() { … }
//}
//public class Derivada : Base
//{
//    public override void M() { … }
//}
