Console.WriteLine("## Structs ##");

Cliente cliente = new Cliente();
cliente.Nome = "Maria";
cliente.Idade = 20;

Console.ReadKey();

public struct Cliente
{
    public string? Nome {  get; set; }
    public int Idade { get; set; }

    public Cliente(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}
