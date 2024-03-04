using System;

namespace Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int produto;
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            produto = a * b;

            Console.WriteLine($"PROD = {produto}");
        }
    }
}