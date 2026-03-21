Console.WriteLine("## Passando argumentos por valor ##\n");

int x = 20;

Console.WriteLine("\nValor do argumento x antes de passar por valor: " + x);
Calculo calc = new();
calc.Dobrar(x);

Console.WriteLine("\nValor do argumento x depois de passar por valor: " + x);


Console.WriteLine("\nValor do argumento x antes de passar por referencia: " + x);
calc.Dobrar(ref x);

Console.WriteLine("\nValor do argumento x depois de passar por referencia: " + x);

Console.ReadKey();

public class Calculo
{
    public void Dobrar(int y)
    {
        y *= 2;
        Console.WriteLine($"\nValor do parametro y no metodo dobrar: {y}");
    }

    public void Dobrar(ref int y)
    {
        y *= 2;
        Console.WriteLine($"\nValor do parametro y no metodo dobrar: {y}");
    }
}
