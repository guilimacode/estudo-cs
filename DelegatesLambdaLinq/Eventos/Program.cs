Console.WriteLine("## Eventos ##!");

var pedido = new Pedido();

pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += SMS.Enviar;

pedido.CriarPedido("email@email.com", "(85) 112233445");

// delegate void PedidoEventHandler();

class PedidoEventArgs : EventArgs
{
    public string? Email { get; set; }
    public string? Telefone { get; set; }
}

class Pedido
{
    //public event PedidoEventHandler? OnCriarPedido;
    public event EventHandler<PedidoEventArgs> OnCriarPedido;

    public void CriarPedido(string email, string fone)
    {
        Console.WriteLine("\nPedido criado !!!");
        if (OnCriarPedido != null)
            OnCriarPedido(this, new PedidoEventArgs { Email = email, Telefone = fone });
    }
}

class Email
{
    public static void Enviar(object? sender, PedidoEventArgs e)
    {
        Console.WriteLine("\nEnviando um email para:" + e.Email);
    }
}

class SMS
{
    public static void Enviar(object? sender, PedidoEventArgs e)
    {
        Console.WriteLine("\nEnviando um SMS para: " + e.Telefone);
    }
}