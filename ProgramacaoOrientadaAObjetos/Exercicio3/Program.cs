using Exercicio3;

Console.WriteLine("## POO - Exercicio 3 ##\n");

Pessoa[] pessoas = new Pessoa[3];

Console.Write("Nome do aluno 1: ");
pessoas[0] = new Aluno(Console.ReadLine());

Console.Write("Nome do aluno 2: ");
pessoas[1] = new Aluno(Console.ReadLine());

Console.Write("Nome do professor: ");
pessoas[2] = new Professor(Console.ReadLine());

foreach (var pessoa in pessoas)
{
    pessoa.ToString();
}

Aluno aluno1 = (Aluno)pessoas[0];
Aluno aluno2 = (Aluno)pessoas[1];
Professor professor = (Professor)pessoas[2];

aluno1.Estudar();
aluno2.Estudar();
professor.Explicar();

Console.ReadKey();
