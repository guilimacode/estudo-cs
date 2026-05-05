using System.Xml.Serialization;

Console.WriteLine("## Desserialização XML ##");

string caminhoArquivo = @"c:\dev\teste.xml";

XmlSerializer serializer = new XmlSerializer(typeof(Aluno));

using (StreamReader reader = new StreamReader(caminhoArquivo))
{
    var aluno = (Aluno)serializer.Deserialize(reader);

    Console.WriteLine($"Aluno XML desserializado " +
        $"\nId:{aluno.Id} \nNome: {aluno.Name} \nEmail: {aluno.Email} \nIdade: {aluno.Idade}");
}

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
