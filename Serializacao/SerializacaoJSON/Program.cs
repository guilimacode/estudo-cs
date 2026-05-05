using System.Text.Json;
using System.Text.Json.Serialization;

Console.WriteLine("## Serialização JSON ##");

Aluno aluno = new Aluno(100, "Guilherme", "guilherme@email.com", 20);

var caminhoArquivo = @"c:\dev\aluno.json";

using (FileStream stream = new FileStream(caminhoArquivo, FileMode.OpenOrCreate, FileAccess.ReadWrite))
{
    JsonSerializer.Serialize(stream, aluno);
}

Console.WriteLine("Objeto serializado para JSON com sucesso");
public class Aluno
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    [JsonIgnore]
    public int Idade { get; set; }

    public Aluno() { }

    public Aluno(int id, string name, string email, int idade)
    {
        Id = id;
        Name = name;
        Email = email;
        Idade = idade;
    }
}
