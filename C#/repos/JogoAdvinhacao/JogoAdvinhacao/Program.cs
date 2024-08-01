/*
nome do programa
regras do jogo
sortear num aleatorio 1-10
    Random random = new Random();
    int numeroaleatorio = random.Next(1, 11);
    Console.WriteLine(numeroaleatorio.ToString());
while/for 3 vezes
    escolha do num pelo usuario
    
    if/else (comparação com num sorteado)
        correto: parabens fim programa
        errado: escolhe de novo

errado +3 vezes
    mostrar num sorteado
*/

//booleano pra saber se mostra ou não o num sorteado
bool acertou = false;

Console.WriteLine("Jogo da Advinhação");
Console.WriteLine("Sorteei um número e você tem 3 chances de acertar...");

Random random = new Random();
int numSorteio = random.Next(1, 11);

//testar com o num certo
//Console.WriteLine(numSorteio);

for (int i = 0; i < 3 && !acertou; i++)
{
    Console.Write("Digite a sua {0}ª tentativa: ", i + 1);
    int tentativa = int.Parse(Console.ReadLine());

    if (tentativa == numSorteio)
    {
        Console.WriteLine("Boa! Você acertou!");
        acertou = true;
    }
    else
    {
        Console.WriteLine("Ops! Não foi esse o número sorteado.");
    }
}

if (!acertou)
{
    Console.WriteLine("Não foi dessa vez... O número sorteado tinha sido {0}", numSorteio);
}