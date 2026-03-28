Console.WriteLine("## Arrays Bidimensionais - Exercicio ##\n");

string?[,] alunos = new string[2, 5];

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.WriteLine($"Digite o nome do aluno [{i},{j}]");
        string? nome = Console.ReadLine();
        alunos[i, j] = nome;
    }
}

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.Write($"[{i},{j}] = {alunos[i, j]}\t ");
    }
}

Console.ReadKey();
