Console.WriteLine("## Arrays como parametros ##");

int[] valores = { 1, 4, 6, 8 };
var resultado = Calcular.Soma(valores);
var resultado2 = Calcular.SomaParams(30, 20, 49, 59); //não precisa passar um array

Console.WriteLine(resultado);
Console.WriteLine(resultado2);

Console.ReadKey();

public class Calcular
{
    public static int Soma(int[] numeros)
    {
        int total = 0;
        foreach (int i in numeros)
        {
            total += i;
        }
        return total;
    }

    public static int SomaParams(params int[] numeros)
    {
        int total = 0;
        foreach (int i in numeros)
        {
            total += i;
        }
        return total;
    }
}
   
