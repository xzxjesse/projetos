/*
12 KM/L
tempo gasto na viagem (em horas) e a velocidade média durante a mesma (em km/h) - dois inteiros
obter distância percorrida
calcular quantos litros seriam necessários
Mostre o valor com 3 casas decimais após o ponto.
*/

using System;

namespace gasto{
    class Program{
        static void Main(string[] args){
            int tempo = Convert.ToInt32(Console.ReadLine());
            int velocidade = Convert.ToInt32(Console.ReadLine());

            double distancia = velocidade * tempo;

            double litros = distancia / 12;

            Console.WriteLine($"{litros:F3}");
        }
    }
}