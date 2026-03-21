Console.WriteLine("## Exercicios Práticos - 2");

Cliente cliente = new Cliente("Guilherme", "teste@teste.com", 17);
Console.WriteLine($"\nNome: {cliente.Nome} \nEmail: {cliente.Email} \nIdade: {cliente.Idade}");
Cliente.ExibirInfo("Teste", "teste2@teste.com", 20);
Cliente.ExibirInfo("Teste Dois", "teste3@teste.com");

Console.ReadKey();

public struct Cliente
{
    public string? Nome;
    public string? Email;
    private int idade;
    public int Idade 
    { get { return idade; }
      set
        {
            if (value < 18)
            {
                idade = 18;
            }
        }
    }

    public Cliente(string? nome, string? email,  int idade)
    {
        Nome = nome;
        Email = email;
        Idade = idade;
    }

    public static void ExibirInfo(string? nome, string? email, int idade = 18)
    {
        Console.WriteLine($"\nNome: {nome} \nEmail: {email} \nIdade: {idade}");
    }
}