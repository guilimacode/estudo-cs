Console.WriteLine("## Arrays - Exercicio 1 ##\n");

string?[] alunos = new string[5];

for (int i = 0; i < alunos.Length; i++)
{
    Console.WriteLine($"\nDigite o nome do aluno {i + 1}:");
    string? nome = Console.ReadLine();
    alunos[i] = nome;
}

double[] notas = new double[5];

for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"\nDigite a nota do aluno {alunos[i]}");
    double nota = Convert.ToDouble(Console.ReadLine());
    notas[i] = nota; 
}

Console.WriteLine("Alunos:");

foreach (string? aluno in alunos)
{
    Console.Write($"{aluno} ");
}

Console.WriteLine("\nNotas:");

foreach (double nota in notas)
{
    Console.Write($"{nota} ");
}

Console.WriteLine("");

double media = notas.Sum(x => x) / notas.Length;

Console.WriteLine("Média das notas: " + media);