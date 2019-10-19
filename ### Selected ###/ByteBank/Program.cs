using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args) {
            #region  Cadastro de Cliente
            System.Console.WriteLine("ByteBank - Cadastro de Clientes");

            System.Console.Write("Nome: ");
            string nome = Console.ReadLine();
            System.Console.WriteLine();

            System.Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            System.Console.WriteLine();

            System.Console.Write("Email: ");
            string email = Console.ReadLine();
            System.Console.WriteLine();

            Cliente cliente1 = new Cliente(nome,cpf,email);
            
            bool trocouSenha = false;
            do {
                System.Console.Write("Senha: ");
                string senha = Console.ReadLine();
                trocouSenha = cliente1.trocaSenha(senha);
                
                if (trocouSenha) {
                    System.Console.WriteLine("Senha alterada com sucesso");
                } else {
                    System.Console.WriteLine("Valor inválido para uma senha");
                }

            } while (!trocouSenha);

            System.Console.WriteLine();
            #endregion

            #region Cadastro de Conta
            System.Console.WriteLine("ByteBank - Cadastro da Conta");
            
            System.Console.Write("Entre com a agencia: ");
            int agencia = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            System.Console.Write("Entre com a conta: ");
            int conta = int.Parse(Console.ReadLine());
            System.Console.WriteLine();
            
            ContaCorrente contaCorrente1 = new ContaCorrente(agencia,conta,cliente1);
            
            double saldo;
            do {
                System.Console.WriteLine("Entre com o saldo: ");
                saldo = double.Parse(Console.ReadLine());

                if (saldo >= 0) {
                    contaCorrente1.saldo = saldo;
                } else {
                    Console.WriteLine("Valor do saldo deve ser positivo");
                    System.Console.WriteLine();
                }
            } while (saldo < 0);
            #endregion

            Cliente cliente2 = new Cliente("Cesar", "123.123.123-12", "oi@hot.com");
            ContaCorrente contaCorrente2 = new ContaCorrente(132, 652, cliente2);
            
            #region Depósito
            Cliente usuario = contaCorrente1.titular;
            System.Console.WriteLine("ByteBank - Depósito em Conta");
            System.Console.WriteLine($"Bem-vindo.... - {usuario.nome}");
            System.Console.WriteLine($"Agencia {contaCorrente1.agencia} Conta: {contaCorrente1.numero}");
            System.Console.WriteLine($"Saldo: {contaCorrente1.saldo}");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite o valor do Depósito: ");
            double valor = double.Parse(Console.ReadLine());
            contaCorrente1.Deposito(valor);
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo saldo: {contaCorrente1.saldo}");
            System.Console.WriteLine();
            #endregion

            #region Saque
            System.Console.WriteLine("ByteBank - Saque");
            System.Console.WriteLine($"Bem-vindo - {usuario.nome}");
            System.Console.WriteLine($"Agencia {contaCorrente1.agencia} Conta: {contaCorrente1.numero}");
            System.Console.WriteLine($"Saldo: {contaCorrente1.saldo}");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite o valor do Saque: ");
            valor = double.Parse(Console.ReadLine());
            contaCorrente1.Saque(valor);
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo saldo: {contaCorrente1.saldo}");
            System.Console.WriteLine();
            #endregion

            #region Transferência
            System.Console.WriteLine("ByteBank - Transferência");
            System.Console.WriteLine($"Bem-vindo - {usuario.nome}");
            System.Console.WriteLine($"Agencia {contaCorrente1.agencia} Conta: {contaCorrente1.numero}");
            System.Console.WriteLine($"Saldo: {contaCorrente1.saldo}");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite o valor da Transferência: ");
            valor = double.Parse(Console.ReadLine());
            if (contaCorrente1.Transferencia(contaCorrente2,valor)){
                System.Console.WriteLine("Transferência efetuada");
            } else {
                System.Console.WriteLine("Não foi possível realizar a operação");
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo saldo origem: {contaCorrente1.saldo}");
            System.Console.WriteLine($"Novo saldo destino: {contaCorrente2.saldo}");
            System.Console.WriteLine();
            #endregion
        }
    } 
}
