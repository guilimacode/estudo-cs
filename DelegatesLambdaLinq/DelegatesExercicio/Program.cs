Console.WriteLine("Delegates - Exercicio");

List<Pessoa> pessoas = new List<Pessoa>()
{
    new("João", 20),
    new("Maria", 18),
    new("Pedro", 25),
    new("Carlos", 15),
    new("Ana", 17)
};

//Percorrer a lista de pessoas e imprimir o nome e idade de cada uma

Action<Pessoa> imprimirNome = x => Console.WriteLine($"Nome: {x.Nome} - Idade: {x.Idade}");
pessoas.ForEach(imprimirNome);

//Filtrar a lista, retornando apenas os que possuem idade maior que 18 anos

Predicate<Pessoa> maiores = x => x.Idade >= 18;
var pessoasMaiores = pessoas.FindAll(maiores);
pessoasMaiores.ForEach(imprimirNome);

//Obter nome e idade da pessoa mais velha

Func<Pessoa, int> obterIdade = p => p.Idade;
int idadeMaxima = pessoas.Max(obterIdade);
var pessoaMaisVelha = pessoas.Find(p => p.Idade == idadeMaxima);

Console.WriteLine($"Pessoa mais velha é {pessoaMaisVelha.Nome} - Idade: {pessoaMaisVelha.Idade}");

public class Pessoa
{
    public Pessoa(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public string? Nome { get; set; }
    public int Idade { get; set; } 
}