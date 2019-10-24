using System;

namespace _3Combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempo = 0;
            double velocidade = 0;

            System.Console.WriteLine("Informe o tempo (em horas) da viagem: ");
            tempo = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Informe a velocidade (em Km) do veículo: ");
            velocidade = double.Parse(Console.ReadLine());

            double distancia = tempo * velocidade;
            System.Console.WriteLine();
            System.Console.WriteLine($"A distância percorrida foi de {distancia}Km");
            System.Console.WriteLine($"O tempo foi gasto foi de {tempo} horas");
            System.Console.WriteLine($"A velocidade média foi de {velocidade}Km");

            double litrosUsado = distancia / 12;
            System.Console.WriteLine($"O litros de gasolina usados foi de {litrosUsado}L");
            System.Console.WriteLine();

        }
    }
}
