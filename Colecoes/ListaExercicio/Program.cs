Console.WriteLine("## Lista - Exercicio ##\n");

List<Aluno> alunos = [
    new("Maria", 8.75),
    new("Manoel", 6.95),
    new("Amanda", 7.25),
    new("Carlos", 6.55),
    new("Jaime", 8.50),
    new("Debora", 5.95),
    new("Alicia", 9.25),
    new("Sandra", 5.55),
    new("Marta", 7.85),
    new("Sueli", 9.15)
];

Aluno.ExibirLista(alunos);

alunos.Add(new("Bia", 7.75));
alunos.Add(new("Mario", 8.95));

Aluno.ExibirLista(alunos);

var alunoParaRemover = alunos.FindIndex(i => i.Nome == "Amanda");
alunos.RemoveAt(alunoParaRemover);

Aluno.ExibirLista(alunos);

var listaOrdenada = alunos.OrderBy(i => i.Nome).ToList();

Console.WriteLine("\nLista de alunos ordenada: \n");
Aluno.ExibirLista(listaOrdenada);

Console.WriteLine("\nAlunos com nota maior ou igual a 8: ");
var alunosAprovados = alunos.FindAll(a => a.Nota >= 8);
Aluno.ExibirLista(alunosAprovados);

Console.ReadKey();

public class Aluno
{
    public string? Nome { get; set; }
    public double Nota { get; set; }

    public Aluno(string? nome, double nota)
    {
        Nome = nome;
        Nota = nota;
    }

    public static void ExibirLista(List<Aluno> alunos)
    {
        double somaNotas = 0.00;
        int qtd_alunos = alunos.Count;
        foreach (Aluno a in alunos)
        {
            Console.WriteLine($"{a.Nome} - {a.Nota}");
            somaNotas += a.Nota;
        }

        Console.WriteLine($"\nMédia das notas: {somaNotas / qtd_alunos}");
        Console.WriteLine($"Quantidade de alunos: {qtd_alunos}");

    }
}
