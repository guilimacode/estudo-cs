Console.WriteLine("## Multicast Delegates ##\n");

SendMessage sendMessage = Metodo1;
sendMessage += Metodo2; // Adicionando na lista de metodos
sendMessage += Metodo3;
sendMessage.Invoke("Olá, multicast!");

sendMessage -= Metodo2;

Console.ReadKey();


static void Metodo1(string msg)
{
    Console.WriteLine("Método 1: " + msg);
}

static void Metodo2(string msg)
{
    Console.WriteLine("Método 2: " + msg);
}

static void Metodo3(string msg)
{
    Console.WriteLine("Método 3: " + msg);
}

public delegate void SendMessage(string msg);