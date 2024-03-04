using System;

namespace Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media;
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            media = ((a*2) + (b*3) + (c*5)) / 10;

            Console.WriteLine($"MEDIA = {media.ToString("F1")}");
        }
    }
}