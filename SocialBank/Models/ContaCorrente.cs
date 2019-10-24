using System;

namespace SocialBank.Models
{
    public class ContaCorrente
    {
        public string titular {get;set;}
        public int agencia {get;set;}
        public int conta {get;set;}
        public double saldo {get;set;}

        public ContaCorrente(int agencia, int conta, string titular)
        {
            this.agencia = agencia;
            this.conta = conta;
            this.titular = titular;
            this.saldo = 0.0;
        }

        public double Deposito(double valor)
        {
            return this.saldo += valor;
        }

        public bool Saque(double valor)
        {
            if(valor <= saldo)
            {
                this.saldo -= valor;
                return true;
            } else {
                return false;
            }
        }
    }
}