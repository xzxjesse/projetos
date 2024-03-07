//(4/3.0) * pi * R3 
//pi=3.14159

using System;

namespace Esfera{
    internal class Program{
        static void Main (string[] args){
            const double pi = 3.14159;
            double volume;
            double raio = double.Parse(Console.ReadLine());
            
            volume = (4/3.0) * pi * Math.Pow(raio, 3);
            Console.WriteLine($"VOLUME = {volume:F3}"); 
        }
    }
}