/*
using System;

namespace cedulas{
    class Program{
        static void Main(string[] args){
            int N = Convert.ToInt32(Console.ReadLine());

            int total = N;

            int notas100 = 0;
            int notas50 = 0;
            int notas20 = 0;
            int notas10 = 0;
            int notas5 = 0;
            int notas2 = 0;
            int notas1 = 0;

            if(N>0 && N<1000000){
                while (N>=100){
                    N-=100;
                    notas100++;
                }
                while (N>=50){
                    N-=50;
                    notas50++;
                }
                while (N>=20){
                    N-=20;
                    notas20++;
                }
                while (N>=10){
                    N-=10;
                    notas10++;
                }
                while (N>=5){
                    N-=5;
                    notas5++;
                }
                while (N>=2){
                    N-=2;
                    notas2++;
                }
                while (N>=1){
                    N-=1;
                    notas1++;
                }
            }

            Console.WriteLine($"{N}");
            Console.WriteLine($"{notas100} nota(s) de R$ 100,00");
            Console.WriteLine($"{notas50} nota(s) de R$ 50,00");
            Console.WriteLine($"{notas20} nota(s) de R$ 20,00");
            Console.WriteLine($"{notas10} nota(s) de R$ 10,00");
            Console.WriteLine($"{notas5}  nota(s) de R$ 5,00");
            Console.WriteLine($"{notas2}  nota(s) de R$ 2,00");
            Console.WriteLine($"{notas1}  nota(s) de R$ 1,00");
        }
    }
}
*/

using System;

namespace cedulas{
    class Program{
        static void Main(string[] args){
        int notes, aux;

        notes=int.Parse(Console.ReadLine());
        
        Console.WriteLine(notes);
        
        Console.WriteLine("{0} nota(s) de R$ 100,00", notes/100);
        aux = (notes%100);

        Console.WriteLine("{0} nota(s) de R$ 50,00", aux/50);
        aux = (aux%50);

        Console.WriteLine("{0} nota(s) de R$ 20,00", aux/20);
        aux = (aux%20);

        Console.WriteLine("{0} nota(s) de R$ 10,00", aux/10);
        aux = (aux%10);

        Console.WriteLine("{0} nota(s) de R$ 5,00", aux/5);
        aux = (aux%5);

        Console.WriteLine("{0} nota(s) de R$ 2,00", aux/2);
        aux = (aux%2);

        Console.WriteLine("{0} nota(s) de R$ 1,00", aux/1);
        }
    }
}