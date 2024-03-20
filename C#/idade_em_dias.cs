/*
Ler um valor inteiro correspondente à idade de uma pessoa em dias
 e informe-a em anos, meses e dias

ano com 365 dias
mês com 30 dias
*/

/*
Ler um valor inteiro correspondente à idade de uma pessoa em dias
 e informe-a em anos, meses e dias

ano com 365 dias
mês com 30 dias
*/

using System;

namespace idade{
    class Program{
        static void Main(string[] args){
        int idade, aux;

        idade=int.Parse(Console.ReadLine());
                
        Console.WriteLine("{0} ano(s)", idade/365);
        aux = (idade%365);

        Console.WriteLine("{0} mes(es)", aux/30);
        aux = (aux%30);

        Console.WriteLine("{0} dia(s)", aux/1);
        }
    }
}