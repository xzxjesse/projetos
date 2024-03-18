using System;

namespace Consumo{
    internal class Program{
        static void Main (string[] args){
            //ler o int distancia
            int X = Convert.ToInt32(Console.ReadLine());

            //ler o double combustivel
            double Y = Convert.ToDouble(Console.ReadLine());

            //aplicar formula do consumo
            double consumo = X/Y;

            //apresentar resultado 
            Console.WriteLine($"{consumo:F3} km/l");
        }
    }
}