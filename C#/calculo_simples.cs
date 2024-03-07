using System;

namespace calculo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ler a linha como uma string
            string linha1 = Console.ReadLine();
            string linha2 = Console.ReadLine();

            // Dividir a linha em partes usando o espaço como separador
            string[] partes1 = linha1.Split(' ');
            string[] partes2 = linha2.Split(' ');

            // Converter as partes para os tipos de dados desejados
            int codigo1 = Convert.ToInt32(partes1[0]);
            int quantidade1 = Convert.ToInt32(partes1[1]);
            double valor1 = Convert.ToDouble(partes1[2]);
            int codigo2 = Convert.ToInt32(partes2[0]);
            int quantidade2 = Convert.ToInt32(partes2[1]);
            double valor2 = Convert.ToDouble(partes2[2]);

            double preco; 

            preco = quantidade1 * valor1 + quantidade2 * valor2;

            Console.WriteLine($"VALOR A PAGAR: R$ {preco:F2}");
            
        }
    }
}