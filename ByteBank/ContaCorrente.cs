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

            
        }
    }
}