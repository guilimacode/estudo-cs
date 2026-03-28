Console.WriteLine("## Classes derivadas - Herança ##\n");

Funcionario funci = new();
funci.Nome = "João";
funci.Email = "joao@email.com";
funci.Empresa = "Microsoft";
funci.Salario = 20000;
funci.Identificar();

Aluno aluno = new Aluno();
aluno.Nome = "Guilherme";
aluno.Email = "guilherme@email.com";
aluno.Curso = "Ciência da Computação";
aluno.Nota = 9;
aluno.Identificar();


Console.ReadKey();

public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }

    public void Identificar()
    {
        Console.WriteLine($"{Nome} - {Email}");
    }
}

public class Funcionario : Pessoa
{
    public string? Empresa { get; set; }
    public decimal Salario { get; set; }
}

public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public int Nota { get; set; }
}
