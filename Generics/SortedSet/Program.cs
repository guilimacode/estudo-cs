Console.WriteLine("## Sorted Set ##");

var numeros = new List<int> { 1, 5, 3, 4, 2 };
SortedSet<int> conjunto = new SortedSet<int>(numeros);
ExibirColecao(numeros);

var frutas = new SortedSet<string> { "uva", "banana", "pera", "kiwi" };
ExibirColecao(frutas);

SortedSet<int> pares = new SortedSet<int>();
for (int i = 6; i > 0; i--)
{
    pares.Add(i);
}
ExibirColecao(pares);

static void ExibirColecao<T>(IEnumerable<T> numeros)
{
    foreach (var i in numeros)
    {
        Console.WriteLine(i);
    }
}