namespace Calculadora.Tests
{
    public class CalculadoraTest
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(5, CalculadoraExample.Calculadora.Somar(2, 3));
        }
        [Fact]
        public void Subtrair()
        {
            Assert.Equal(5, CalculadoraExample.Calculadora.Subtrair(10, 5));
        }
        [Fact]
        public void Multiplicar()
        {
            Assert.Equal(10, CalculadoraExample.Calculadora.Multiplicar(5, 2));
        }
        [Fact]
        public void Dividir()
        {
            Assert.Equal(2, CalculadoraExample.Calculadora.Dividir(10, 5));
        }

    }
}
public class BhaskaraCalculatorTests
{
    [Fact]
    public void TestarRaizesReais()
    {
        var calculadora = new BhaskaraCalculator();
        double a = 1, b = -3, c = 2;

        var (x1, x2) = calculadora.Calcular(a, b, c);

        Assert.Equal(2, x1);
        Assert.Equal(1, x2);
    }

    [Fact]
    public void TestarSemRaizesReais()
    {
        var calculadora = new BhaskaraCalculator();
        double a = 1, b = 1, c = 1;

        var (x1, x2) = calculadora.Calcular(a, b, c);

        Assert.Null(x1);
        Assert.Null(x2);
    }

    [Fact]
    public void TestarCoeficienteAZero()
    {
        var calculadora = new BhaskaraCalculator();
        double a = 0, b = 2, c = 1;

        var (x1, x2) = calculadora.Calcular(a, b, c);

        Assert.Null(x1);
        Assert.Null(x2);
    }
}