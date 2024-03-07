//(A * B - C * D)

using System;

namespace Diferenca
{
    internal class Program
    {
        static void Main (string[] args)
        {
            int diferenca;
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            diferenca = (a * b - c * d);

            Console.WriteLine($"DIFERENCA = {diferenca}");
        }
    }
}