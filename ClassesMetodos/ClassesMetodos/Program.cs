Console.WriteLine("## Classes e Métodos ##\n");

Pessoa p1 = new Pessoa();
p1.nome = "Maria";
p1.idade = 24;
p1.sexo = "F";

Console.WriteLine($"{p1.nome}, {p1.idade}, {p1.sexo}");

Pessoa p2 = new();
p1.nome = "João";
p1.idade = 23;
p1.sexo = "M";

Console.WriteLine($"{p2.nome}, {p2.idade}, {p2.sexo}");
Console.ReadKey();

class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}