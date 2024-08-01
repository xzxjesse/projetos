/*
nome programa
ler quantidade de provas
    verificar a leitura e intervalo valido
quantidade{
ler nota
    verificar
ler peso
    verificar
}
((nota*peso)...)/pesos somados
mostrar resultado
    >=7 aprovado
    5-6.9 recuperação
    <5 reprovado
*/


Console.WriteLine("Cálculadora de média");

Console.Write("Quantas provas você quer analisar? ");
int numProvas = int.Parse(Console.ReadLine());

// teste quantidade lida
// Console.WriteLine(numProvas);

while (numProvas <= 0)
{
    Console.Write("Erro: O número de provas deve ser maior que zero. Digite novamente:");
    numProvas = int.Parse(Console.ReadLine());
}

double[] notas = new double[numProvas];
int[] pesos = new int[numProvas];

for (int i = 0; i < numProvas; i++)
{
    Console.Write("Nota da prova {0} (0,00-10,00): ", i + 1);
    notas[i] = double.Parse(Console.ReadLine());

    // conferir intervalo 0-10 notas
    while (notas[i] < 0.00 || notas[i] > 10.00)
    {
        Console.Write("Erro: A nota deve estar entre 0,00 e 10,00.  Digite novamente: ");
        notas[i] = double.Parse(Console.ReadLine());
    }

    Console.Write("Peso da prova {0} (0-10): ", i + 1);
    pesos[i] = int.Parse(Console.ReadLine());

    // conferir intervalo 0-10 pesos
    while (pesos[i] < 0 || pesos[i] > 10)
    {
        Console.Write("Erro: O peso deve estar entre 0 e 10. Digite novamaente: ");
        pesos[i] = int.Parse(Console.ReadLine());
    }

    //teste notas e pesos lidos
    //Console.Write(notas[i]);
    //Console.Write(pesos[i]);
}

double mediaPonderada = 0;
double somaPesos = 0;

for (int i = 0; i < numProvas; i++)
{
    mediaPonderada += notas[i] * pesos[i];
    somaPesos += pesos[i];
}

mediaPonderada /= somaPesos;

Console.WriteLine("\nMÉDIA: {0:F2}", mediaPonderada);

if (mediaPonderada >= 7)
{
    Console.WriteLine("Você está aprovado!");
}
else if (mediaPonderada >= 5 && mediaPonderada <= 6.9)
{
    Console.WriteLine("Você está de recuperação!");
}
else
{
    Console.WriteLine("Você está reprovado!");
}