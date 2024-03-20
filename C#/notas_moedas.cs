using System;

namespace dinheiro{
    class Program{
        static void Main(string[] args){
        int dinheiro, aux;
        double dinheiroDouble;

        dinheiro=int.Parse(Console.ReadLine());
        dinheiroDouble = dinheiro;

        Console.WriteLine("NOTAS:");
                
        Console.WriteLine("{0} nota(s) de R$ 100.00", dinheiro/100);
        aux = (dinheiro%100);

        Console.WriteLine("{0} nota(s) de R$ 50.00", aux/50);
        aux = (aux%50);

        Console.WriteLine("{0} nota(s) de R$ 20.00", aux/20);
        aux = (aux%20);

        Console.WriteLine("{0} nota(s) de R$ 10.00", aux/10);
        aux = (aux%10);

        Console.WriteLine("{0} nota(s) de R$ 5.00", aux/5);
        aux = (aux%5);

        Console.WriteLine("{0} nota(s) de R$ 2.00", aux/2);
        aux = (aux%2);

        Console.WriteLine("MOEDAS:");

        Console.WriteLine("{0} moeda(s) de R$ 1.00", aux/1);
        dinheiroDouble -= (aux / 1)*1;

        aux = (int)(dinheiroDouble*100);

        Console.WriteLine("{0} moeda(s) de R$ 0.50", aux/50);
        aux = (aux%50);

        Console.WriteLine("{0} moeda(s) de R$ 0.25", aux/25);
        aux = (aux%25);

        Console.WriteLine("{0} moeda(s) de R$ 0.10", aux/10);
        aux = (aux%10);

        Console.WriteLine("{0} moeda(s) de R$ 0.05", aux/5);
        aux = (aux%5);

        Console.WriteLine("{0} moeda(s) de R$ 0.01", aux/1);
        }
    }
}