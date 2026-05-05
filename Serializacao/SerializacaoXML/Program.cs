using System.Xml.Serialization;

Console.WriteLine("## Serialização XML ##");

Aluno aluno1 = new Aluno(100, "Guilherme", "guilherme@email.com", 19);

string caminhoArquivo = @"c:\dev\teste.xml";

XmlSerializer serializer = new XmlSerializer(typeof(Aluno));

using (StreamWriter writer = new StreamWriter(caminhoArquivo))
{
    serializer.Serialize(writer, aluno1);
}

Console.WriteLine("Objeto serializado para XML com sucesso!");
public class Aluno
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int Idade;

    public Aluno(){}

    public Aluno(int id, string name, string email, int idade)
    {
        Id = id;
        Name = name;
        Email = email;
        Idade = idade;
    }
}
