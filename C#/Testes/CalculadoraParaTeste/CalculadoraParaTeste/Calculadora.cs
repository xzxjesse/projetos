﻿namespace Calculadora
{
    public class Calculadora
    {
        public int somar(int a, int b)
        {
            return a + b;
        }

        public int subtrair(int a, int b)
        {
            return a - b;
        }

        public int multiplicar(int a, int b)
        {
            return a * b;
        }

        public int dividir(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Divisão por zero não é permitida.");
            return a / b;
        }
    }
}