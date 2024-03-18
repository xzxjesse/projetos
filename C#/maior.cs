/*
abs: Math.Abs(value);
formula maior1=(a+b+abs(a-b))/2
formula maior2=(maior1+c+abs(maior1-c))/2
*/

using System;

namespace Maior{
    internal class Program{
        static void Main (string[] args){
            //ler a linha
            string valores = Console.ReadLine();

            //separar os valores A B C
            string[] valor = valores.Split(' ');

            int A = Convert.ToInt32(valor[0]);
            int B = Convert.ToInt32(valor[1]);
            int C = Convert.ToInt32(valor[2]);

            //aplicar formulas

            int maior1 = (A+B+(Math.Abs(A-B)))/2;
            int maior2 = (maior1+C+(Math.Abs(maior1-C)))/2;

            //apresentar resultado 
            Console.WriteLine($"{maior2} eh o maior");
        }
    }
}