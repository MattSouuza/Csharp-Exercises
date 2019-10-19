using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public string titular {get;set;}
        public int agencia {get;set;}
        public int numero {get;set;}
        public double saldo {get;set;}
        
        public ContaCorrente(int agencia, int numero, string titular) {
            this.titular = titular;
            this.agencia = agencia;
            this.numero = numero;
            this.saldo = 0.0;
        }
        
        public double Deposito(double valor){
            return this.saldo += valor;
        }

        public bool Saque(double valor){
            if(this.saldo >= valor){
                this.saldo -= valor;
                return true;
            } else {
                return false;
            }
        }

        public bool Transferencia(ContaCorrente contaDestino, double valor){
            if(this.Saque(valor)){
                contaDestino.Deposito(valor);
                return true;
            } else {
                return false;
            }
        }
    }
}