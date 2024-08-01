using Polimorfismo;

Retangulo retangulo = new Retangulo(5, 5);
Circulo circulo = new Circulo(13);
Triangulo triangulo = new Triangulo(7, 4);

Console.WriteLine($"Área do retângulo: {retangulo.CalcularArea()}");
Console.WriteLine($"Área do círculo: {circulo.CalcularArea()}");
Console.WriteLine($"Área do triângulo: {triangulo.CalcularArea()}");

