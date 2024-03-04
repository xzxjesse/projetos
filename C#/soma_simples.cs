using System;

namespace Soma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma;
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            soma = a + b;

            Console.WriteLine($"SOMA = {soma}");
        }
    }
}