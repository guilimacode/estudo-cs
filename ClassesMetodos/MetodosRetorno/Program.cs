Console.WriteLine("## Métodos com Retorno ##\n");

Calculadora calc = new();

Console.WriteLine(calc.Dividir(10, 0));

Console.ReadKey();

public class Calculadora
{
    public int Somar(int n1, int n2)
    {
        return n1 + n2;
    }

    public int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }

    public int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }

    public int Dividir(int n1, int n2)
    {
        if (n2 != 0) 
           return n1 / n2;

        return 0;
    }
}
