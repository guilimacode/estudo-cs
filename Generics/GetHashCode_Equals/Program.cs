Console.WriteLine("## Sobrescrevendo GetHashCode e Equals ##\n");

var pessoa1 = new Pessoa(123456, "Guilherme");
var pessoa2 = new Pessoa(123456, "Guilherme");
var pessoa3 = new Pessoa(120343, "Guilherme");

Console.WriteLine("\nComparando objetos Pessoa - GetHashCode");
Console.WriteLine("pessoa1 = " + pessoa1.GetHashCode());
Console.WriteLine("pessoa2 = " + pessoa2.GetHashCode());
Console.WriteLine("pessoa3 = " + pessoa3.GetHashCode());

Console.WriteLine("\n");

Console.WriteLine("Comparando objetos Pessoa - Equals");

Console.WriteLine("pessoa1.Equals(pessoa2) = " + pessoa1.Equals(pessoa2));
Console.WriteLine("pessoa1.Equals(pessoa3) = " + pessoa1.Equals(pessoa3));

Console.ReadKey();

public class Pessoa
{
    public Pessoa(int cpf, string? nome)
    {
        CPF = cpf;
        Nome = nome;
    }

    public int CPF { get; set; }
    public string? Nome { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if ((obj is not Pessoa)) return false;

        var other = (Pessoa)obj;

        return CPF.Equals(other.CPF);
    }
    public override int GetHashCode()
    {
        return CPF.GetHashCode();
    }
}
