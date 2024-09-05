namespace CalculadoraTest
{
    using Xunit;
    using Calculadora;

    public class CalculadoraTests
    {
        //soma
        [Fact]
        public void somarDeveRetornarSoma()
        {
            // Arrange
            var calculadora = new Calculadora();
            int a = 5;
            int b = 3;

            // Act
            int resultado = calculadora.somar(a, b);

            // Assert
            Assert.Equal(8, resultado);
        }

        //subtrair
        [Fact]
        public void subtrairDeveRetornarSubtracao()
        {
            // Arrange
            var calculadora = new Calculadora();
            int a = 5;
            int b = 3;

            // Act
            int resultado = calculadora.subtrair(a, b);

            // Assert
            Assert.Equal(2, resultado);
        }

        //multiplicar
        [Fact]
        public void multiplicarDeveRetornarMultiplicacao()
        {
            // Arrange
            var calculadora = new Calculadora();
            int a = 5;
            int b = 3;

            // Act
            int resultado = calculadora.multiplicar(a, b);

            // Assert
            Assert.Equal(15, resultado);
        }

        //divisao
        [Fact]
        public void dividirDeveRetornarDivisao()
        {
            // Arrange
            var calculadora = new Calculadora();
            int a = 15;
            int b = 3;

            // Act
            int resultado = calculadora.dividir(a, b);

            // Assert
            Assert.Equal(5, resultado);
        }

        //com zero
        [Fact]
        public void dividirPorZeroDeveGerarExcecao()
        {
            // Arrange
            var calculadora = new Calculadora();
            int a = 10;
            int b = 0;

            // Act e Assert
            Assert.Throws<DivideByZeroException>(() => calculadora.dividir(a, b)); //exceção da divisao
        }

        [Fact]
        public void multiplicarPorZeroDeveRetornarZero()
        {
            // Arrange
            var calculadora = new Calculadora();
            int a = 5;
            int b = 0;

            // Act
            int resultado = calculadora.multiplicar(a, b);

            // Assert
            Assert.Equal(0, resultado);
        }

        [Fact]
        public void somarComZeroDeveRetornarSoma()
        {
            // Arrange
            var calculadora = new Calculadora();
            int a = 5;
            int b = 0;

            // Act
            int resultado = calculadora.somar(a, b);

            // Assert
            Assert.Equal(a, resultado);
        }

        [Fact]
        public void subtrairComZeroDeveRetornarSubtracao()
        {
            // Arrange
            var calculadora = new Calculadora();
            int a = 5;
            int b = 0;

            // Act
            int resultado = calculadora.subtrair(a, b);

            // Assert
            Assert.Equal(a, resultado);
        }

        //num negativo
        [Fact]
        public void somarDeveRetornarSomaComNumerosNegativos()
        {
            // Arrange
            var calculadora = new Calculadora();
            int a = -5;
            int b = -3;

            // Act
            int resultado = calculadora.somar(a, b);

            // Assert
            Assert.Equal(-8, resultado);
        }

        [Fact]
        public void subtrairDeveRetornarSubtracaoComNumerosNegativos()
        {
            // Arrange
            var calculadora = new Calculadora();
            int a = -5;
            int b = -3;

            // Act
            int resultado = calculadora.subtrair(a, b);

            // Assert
            Assert.Equal(-2, resultado);
        }

        [Fact]
        public void multiplicarDeveRetornarMultiplicacaoComNumerosNegativos()
        {
            // Arrange
            var calculadora = new Calculadora();
            int a = 5;
            int b = -3;

            // Act
            int resultado = calculadora.multiplicar(a, b);

            // Assert
            Assert.Equal(-15, resultado);
        }

        [Fact]
        public void dividirDeveRetornarDivisaoComNumerosNegativos()
        {
            // Arrange
            var calculadora = new Calculadora();
            int a = -15;
            int b = 3;

            // Act
            int resultado = calculadora.dividir(a, b);

            // Assert
            Assert.Equal(-5, resultado);
        }

        //todas as operações juntas (expressão numérica)
        [Fact]
        public void deveCalcularExpressaoNumerica() //(5+3)*2-10/2
                                                    //8*2-5
                                                    //16-5
                                                    //11
        {
            // Arrange
            var calculadora = new Calculadora();
            int a = 5;
            int b = 3;
            int c = 2;
            int d = 10;
            int e = 2;

            // Act
            int soma = calculadora.somar(a, b); //prioridade por parenteses
            int divisao = calculadora.dividir(d, e); //simultanea por nao depender de resultado
            int multiplicacao = calculadora.multiplicar(soma, c); //prioridade dps de parenteses
            int resultadoFinal = calculadora.subtrair(multiplicacao, divisao); //finaliza com os dados recebidos

            // Assert
            Assert.Equal(11, resultadoFinal);
        }


        //requer alteração na classe da Calculadora:
            //OverFlow do int
            //outros tipos de dados
    }
}