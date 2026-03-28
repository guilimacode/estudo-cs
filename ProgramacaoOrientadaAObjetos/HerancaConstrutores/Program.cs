Console.WriteLine("## Herança - Construtores ##\n");

Aluno aluno1 = new();
Console.WriteLine("\n");
Aluno aluno2 = new("José");

Console.ReadKey();

public class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Construtor da classe pessoa sem parametro");
    }

    public Pessoa(string? Nome)
    {
        Console.WriteLine("Construtor da classe pessoa com parametro");
    }
}

public class Aluno : Pessoa
{
    public Aluno() : base()
    {
        Console.WriteLine("Construtor da classe aluno sem parametro");
    }

    public Aluno(string? Nome) : base(Nome)
    {
        Console.WriteLine("Construtor da classe aluno com parametro");
    }
}
