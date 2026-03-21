Console.WriteLine("## Sobrecarga de metodos ##\n");

Email email = new Email();

email.enviar("Endereço", "Reunião de alinhamento");
Console.ReadKey();

public class Email
{
    public void enviar(string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Assunto padrão");
    }

    public void enviar(string endereco, string assunto)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{assunto}");
    }

    public void enviar(decimal valor, string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Proposta comercial");
        Console.WriteLine($"{valor}");
    }
}

