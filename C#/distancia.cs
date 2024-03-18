//Tempo=2×Distância

using System;

namespace Distancia{
    class Program{
        static void Main(string[] args){
            //ler int de distancia
            int distancia = Convert.ToInt32(Console.ReadLine());

            //calcula o tempo para essa distancia
            double tempo = 2 * distancia;

            //apresenta o resultado em minutos
            Console.WriteLine($"{tempo} minutos");

        }
    }
}