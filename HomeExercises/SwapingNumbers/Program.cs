using System;

namespace SwapingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //The way I did
            int num1;
            int num2;

            System.Console.WriteLine("Type a number: ");
            num1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Type another number: ");
            num2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine();
            
            int swap1 = num2;
            int swap2 = num1;
            
            System.Console.WriteLine("The numbers typed will be swaped: ");
            System.Console.WriteLine("The first number now is "+swap1);
            System.Console.WriteLine("The second number now is "+swap2);
            System.Console.WriteLine();

            //The other way to do this

            System.Console.WriteLine("Type a number: ");
            num1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Type another number: ");
            num2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            /**
            * * --------------------------------------------
            * * see the Explanation.png to understand better
            */

            int swaper;
            swaper = num1;
            num1 = num2;
            num2 = swaper;

            /**
            * * --------------------------------------------
            */

            System.Console.WriteLine("The numbers typed will be swaped: ");
            System.Console.WriteLine("The first number now is "+num1);
            System.Console.WriteLine("The second number now is "+num2);
            System.Console.WriteLine();
        }
    }
}
