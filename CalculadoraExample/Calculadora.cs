namespace CalculadoraExample
{
    public class Calculadora
    {
        public static int Somar(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }
        public static int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }
        public static int Dividir(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}

public class BhaskaraCalculator
{
    public (double? x1, double? x2) Calcular(double a, double b, double c)
    {
        if (a == 0)
        {
            return (null, null);
        }

        double delta = b * b - 4 * a * c;

        if (delta < 0)
        {
            return (null, null);
        }

        double sqrtDelta = Math.Sqrt(delta);
        double x1 = (-b + sqrtDelta) / (2 * a);
        double x2 = (-b - sqrtDelta) / (2 * a);

        return (x1, x2);
    }
}