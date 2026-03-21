Console.WriteLine("## Construtores ##\n");

Aluno aluno = new Aluno("aluno", 19, "M", "S");
Aluno aluno2 = new Aluno("Aluno 2");

Console.ReadKey();

public class Aluno
{
    public Aluno(string nome) => Nome = nome;

    public Aluno(string nome, int idade, string sexo, string aprovado):this(nome)
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }

    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}
