using System.Text.Json;
using System.Xml.Serialization;

Console.WriteLine("## Desserialização JSON ##");

string caminhoArquivo = @"c:\dev\aluno.json";

string jsonContent = File.ReadAllText(caminhoArquivo);

var aluno = JsonSerializer.Deserialize<Aluno>(jsonContent);

Console.WriteLine($"Aluno JSON desserializado " +
    $"\nId:{aluno.Id} \nNome: {aluno.Name} \nEmail: {aluno.Email}");


public class Aluno
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int Idade;

    public Aluno() { }

    public Aluno(int id, string name, string email, int idade)
    {
        Id = id;
        Name = name;
        Email = email;
        Idade = idade;
    }
}
