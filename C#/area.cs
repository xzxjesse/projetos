/*leia três valores com ponto flutuante de dupla precisão
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.*/

using System;

namespace Area{
    internal class Program{
        static void Main (string[] args){
            //ler a linha
            string valores = Console.ReadLine();

            //separar os valores A B C
            string[] valor = valores.Split(' ');

            double A = Convert.ToDouble(valor[0]);
            double B = Convert.ToDouble(valor[1]);
            double C = Convert.ToDouble(valor[2]);

            /*conferir valores
            Console.WriteLine($"{A:F3}");
            Console.WriteLine($"{B:F3}");
            Console.WriteLine($"{C:F3}");*/

            //triangulo a=base c=altura
            double triangulo = (A*C)/2;

            //circulo r=c pi=3.14159
            double circulo = 3.14159*Math.Pow(C, 2);

            //trapezio a,b=bases c=altura
            double trapezio = ((A+B)*C)/2;

            //quadrado b=lado
            double quadrado = Math.Pow(B, 2);

            //retangulo a,b=lados
            double retangulo = A*B;

            //apresentar resultado 
            Console.WriteLine($"TRIANGULO: {triangulo:F3}");
            Console.WriteLine($"CIRCULO: {circulo:F3}");
            Console.WriteLine($"TRAPEZIO: {trapezio:F3}");
            Console.WriteLine($"QUADRADO: {quadrado:F3}");
            Console.WriteLine($"RETANGULO: {retangulo:F3}");
        }
    }
}