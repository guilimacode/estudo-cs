Console.WriteLine("## Queue ##");

// First In First Out (FIFO)

Queue<string> diasSemana = new Queue<string>();
diasSemana.Enqueue("Segunda");
diasSemana.Enqueue("Terça");
diasSemana.Enqueue("Quarta");

int[] array1 = new int[] { 2, 4, 6, 8 };
Queue<int> pares = new Queue<int>(array1);

var lista = new List<string>() { "uva", "Pera" };
var frutas = new Queue<string>(lista);

var impares = new Queue<int>(3);
impares.Enqueue(1);
impares.Enqueue(3);
impares.Enqueue(5);

string[] linguagens = { "C#", "Python", "Java", "Ruby" };
Queue<string> fila1 = new Queue<string>(linguagens);

Console.WriteLine($"-A fila original contém {fila1.Count} itens");
ExibirFila(fila1);

//retorna sem remover
Console.WriteLine($"\nitem obtido(Peek) {fila1.Peek()}");

//remove e retorna 
Console.WriteLine($"\nitem removido(Dequeue) {fila1.Dequeue()}");

ExibirFila(fila1);

static void ExibirFila<T>(IEnumerable<T> fila)
{
    foreach (var item in fila)
    {
        Console.WriteLine(item);
    }
}