using System;

namespace _21Caixa
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] money = new int[] {100, 50, 20, 10, 5, 2};
            
            System.Console.WriteLine("Digite o valor a ser sacado: ");
            int value = int.Parse(Console.ReadLine());

            if(value > 0)
            {
                int notas100 = value / money[0];
                int resultado =  (value * money[0]); 

                resultado = resultado / money[1];
                
            }
            System.Console.WriteLine(value);
        }
    }
}
