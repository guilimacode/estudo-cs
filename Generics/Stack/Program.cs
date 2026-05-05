Console.WriteLine("## Stack ##");

// Last In First Out (LIFO)

Stack<string> diasSemana = new Stack<string>();
diasSemana.Push("Segunda");
diasSemana.Push("Terça");
diasSemana.Push("Quarta");
ExibirStack(diasSemana);

int[] array1 = new int[] { 2, 4, 6, 8 };
Stack<int> pares = new Stack<int>(array1);

var lista = new List<string>() { "uva", "pera" };
var frutas = new Stack<string>(lista);
ExibirStack(frutas);

var impares = new Stack<int>(3);
impares.Push(3);
impares.Push(4);
impares.Push(5);
ExibirStack(impares);

Stack<int> numeros = new Stack<int>();
numeros.Push(10);
numeros.Push(20);
numeros.Push(30);
numeros.Push(10);

Console.WriteLine($"-A pilha original contém {numeros.Count} itens");
ExibirStack(numeros);

//retorna sem remover
Console.WriteLine($"\nitem obtido(Peek) {numeros.Peek()}");

//remove e retorna 
Console.WriteLine($"\nitem removido(Pop) {numeros.Pop()}");

ExibirStack(numeros);

if (numeros.Contains(20))
    Console.WriteLine("\nItem 20 está na pilha.");
else
    Console.WriteLine("\nItem 20 não está na pilha.");
static void ExibirStack<T>(IEnumerable<T> stack)
{
    foreach (var item in stack)
    {
        Console.WriteLine(item);
    }
}

var copia = new Stack<int>(numeros.ToArray());
ExibirStack(copia);