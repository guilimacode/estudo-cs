Console.WriteLine("## Metodos Estáticos ##");

// Também chamados de Métodos de classe

Console.WriteLine(Calculadora.Somar(10, 20));
Console.ReadKey();

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
        if (n2 != 0)
            return n1 / n2;

        return 0;
    }
}
