Console.WriteLine("## Campos estáticos ##");

ContaCorrente c1 = new();
c1.Conta = 182;
c1.Nome = "Maria";

ContaCorrente c2 = new();
c2.Conta = 102;
c2.Nome = "Marta";

ContaCorrente.Juros = 3.25f;

Console.WriteLine($"Cliente: {c1.Nome} - Juros Anual: {c1.JurosAnual()}");
Console.WriteLine($"Cliente: {c2.Nome} - Juros Anual: {c2.JurosAnual()}");


Console.ReadKey();


public class ContaCorrente
{
    public int Conta;
    public string? Nome;
    public static float Juros;

    public float JurosAnual()
    {
        return Juros * 12;
    }
}


