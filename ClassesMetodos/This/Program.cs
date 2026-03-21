Console.WriteLine("## this ##");

Cliente cliente = new("Cliente", 20);
Teste t1 = new Teste();

t1.Num1 = 87;
t1.Num2 = 34;
t1.Exibir();

Console.ReadKey();

public class Cliente
{
    public string? Nome;
    public int Idade;

    public Cliente(string? Nome, int Idade)
    {
        this.Nome = Nome;
        this.Idade = Idade;
    }
}

public class Teste
{
    public int Num1;
    public int Num2;

    public void PassarParametro(Teste t)
    {
        Console.WriteLine($"\n this = {this}");
        Console.WriteLine("Num1: " + t.Num1);
        Console.WriteLine("Num2: " + t.Num2);
    }

    public void Exibir() => PassarParametro(this);
}
