using System;

namespace SocialBank.Models
{
    public class ContaSocial
    {
        public string titular {get;set;}
        public int agencia {get;set;}
        public int conta {get;set;}
        public double saldo {get;set;}

        public ContaSocial(int agencia, int conta, string titular)
        {
            this.titular = titular;
            this.agencia = agencia;
            this.conta = conta;
            this.saldo = 0.0;
        }

        public ContaSocial(int agencia, int conta, UserLogin userLogin1)
        {
            this.agencia = agencia;
            this.conta = conta;
        }

        public double Deposito(double valor)
        {
            return this.saldo += valor;
        }

        public bool Pagamento(double valor)
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