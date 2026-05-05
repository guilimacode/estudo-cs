Console.WriteLine("## Queue - Exercicio ##");

Queue<Pedido> filaPedido = new Queue<Pedido>();

filaPedido.Enqueue(new Pedido(101, 10.0));
filaPedido.Enqueue(new Pedido(102, 20.0));
filaPedido.Enqueue(new Pedido(103, 30.0));

//exibi o numero de pedidos na fila
Console.WriteLine($"Número de pedidos na fila : {filaPedido.Count}");

while(filaPedido.Count > 0)
{
    Pedido proximoPedido = filaPedido.Dequeue();
    Console.WriteLine($"Processando pedido {proximoPedido.Numero}");
}

class Pedido
{
    public Pedido(int numero, double valor)
    {
        Numero = numero;
        Valor = valor;
    }
    public int Numero { get; set; } 
    public double Valor { get; set; }
}
