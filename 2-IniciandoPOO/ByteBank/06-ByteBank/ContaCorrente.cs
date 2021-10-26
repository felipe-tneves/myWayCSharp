﻿


namespace _06_ByteBank
{
    public class ContaCorrente
    {
        //private Cliente _titular;

        //public Cliente Titular
        //{
        //    get
        //    {
        //        return _titular;
        //    }
        //    set
        //    {
        //        _titular = value;
        //    }
        //}

        public Cliente Titular { get; set; }

        //public int agencia;
        public int Agencia { get; set; }

        //public int numero;
        public int Numero { get; set; }

        private double _saldo = 100;


        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        //public void SetSaldo(double saldo)
        //{
        //    if (saldo < 0)
        //    {
        //        return;
        //    }
            
        //    this.saldo = saldo;
            
        //}

        //public double GetSaldo()
        //{
        //    return saldo;
        //}

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);

            return true;
        }
    }

}