/*
nome programa
ler tipo de conversao
    F->C
    C->F
switch (expressao)
{
    case valor1:
        c->f
        break;
    case valor2:
        f->c
        break;
    default:
        mensagem de erro
        break;
}
*/

int tipo;
double graus, convertido;

Console.WriteLine("Conversor de temperaturas");

Console.WriteLine("Qual é o tipo de conversão que você quer fazer?");
Console.WriteLine("1 - Celsius -> Fahrenheit");
Console.WriteLine("2 - Fahrenheit -> Celsius");

while (!int.TryParse(Console.ReadLine(), out tipo) || tipo < 1 || tipo > 2)
{
    Console.WriteLine("Erro: Digite um número válido (1 ou 2):");
}


switch (tipo)
{
    case 1:
        Console.Write("Informe o valor em graus Celsius: ");
        double.TryParse(Console.ReadLine(), out graus);
        convertido = graus * 1.8 + 32;
        Console.WriteLine("{0:F2}°F", convertido);
        break;
    case 2:
        Console.Write("Informe o valor em graus Fahrenheit: ");
        double.TryParse(Console.ReadLine(), out graus);
        convertido = (graus - 32) / 1.8;
        Console.WriteLine("{0:F2}°C", convertido);
        break;
}