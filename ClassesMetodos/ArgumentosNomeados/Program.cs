Console.WriteLine("## Argumentos nomeados ##");

Email email = new();

email.Enviar("teste@email.com", "Urgente", "Reunião de Orçamento");
email.Enviar(titulo: "Urgente", destino: "teste@email.com", assunto: "Reunião de Orçamento");

public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\n Para:{destino} - {titulo} \n Assunto: {assunto}");
    }
}
