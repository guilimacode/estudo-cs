Console.WriteLine("## Herança - Modificadores Virtual e Override ##");

Gato gato = new Gato();
gato.Nome = "Miauzinho";

Cachorro cachorro = new Cachorro();
cachorro.Nome = "Auau";

gato.ExibeNome();
cachorro.ExibeNome();

Console.ReadKey();

public class Animal
{
    public string? Nome { get; set; }
    public virtual void ExibeNome()
    {
        Console.WriteLine($"Oi, meu nome é {Nome}");
    }
}

public class Gato : Animal
{
    public override void ExibeNome()
    {
        Console.WriteLine($"Oi, sou um gato e meu nome é {Nome}");
    }
}

public class Cachorro : Animal
{
}
