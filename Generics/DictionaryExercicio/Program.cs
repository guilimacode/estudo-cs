Console.WriteLine("## Exericio - Dictionary##\n");

Dictionary<int, Aluno> alunos = new Dictionary<int, Aluno>()
{
    {1, new("Maria", 7)},
    {2, new("Eric", 8)},
    {3, new("Ana", 9 )},
    {4, new("Alex", 6)},
    {5, new("Guilherme", 5)}
};

Console.WriteLine("Exibindo nomes e notas dos alunos: ");

foreach (var item in alunos)
{
    Console.WriteLine($"{item.Key} - {item.Value.Nome} - {item.Value.Nota}");
}

do
{
    Console.WriteLine("\nInforme o codigo do aluno que deseja localizar (-1 para sair)");
    int codigo = Convert.ToInt32(Console.ReadLine());

    if (codigo == -1)
        break;

    var resultado = alunos.ContainsKey(codigo);
    if (resultado)
    {
        Console.WriteLine("Informe a nota de 1 a 10: ");
        var nota = Convert.ToInt32(Console.ReadLine());
        alunos[codigo].Nota = nota;
    }
}
while (true);

Console.WriteLine("\n### Removendo um aluno ###");
Console.WriteLine("\nDigite o codigo do aluno que deseja remover");
int cod = Convert.ToInt32(Console.ReadLine());

if(alunos.ContainsKey(cod))
{
    alunos.Remove(cod);
    Console.WriteLine("\nAluno removido com sucesso");
}

Console.WriteLine("\n### Inserindo novo aluno ###");

Console.WriteLine("\nDigite o codigo do aluno");
int codigoNovo = Convert.ToInt32((Console.ReadLine()));

Console.WriteLine("\nDigite o nome do aluno");
string? nome = Console.ReadLine();

Console.WriteLine("\nDigite a nota do aluno");
int notaNovo = Convert.ToInt32(Console.ReadLine());

alunos.Add(codigoNovo, new(nome, notaNovo));

Console.WriteLine("\nLista de alunos ordenada: ");

var alunosOrdenados = alunos.OrderBy(x => x.Value.Nome);

foreach (var item in alunosOrdenados)
{
    Console.WriteLine($"{item.Key} - {item.Value.Nome} - {item.Value.Nota}");
}


Console.WriteLine("\nLimpando a lista de alunos: ");

alunos.Clear();

public class Aluno
{

    public Aluno(string? nome, int nota)
    {
        Nome = nome;
        Nota = nota;
    }

    public string? Nome {  get; set; }
    public int Nota { get; set; }
}