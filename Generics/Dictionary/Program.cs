Console.WriteLine("## Dictionary<T> ##");

Dictionary<int, int> dic1 = new Dictionary<int, int>();
var dic2 = new Dictionary<int, int>();

dic2.Add(2, 400);
dic2.Add(4, 800);
dic2.Add(6, 1200);

var dic3 = new Dictionary<int, int>()
{
    {1, 100},
    {2, 200},
    {3, 300}
};

Console.WriteLine("\nUsando o metodo TryAdd para inserir valor 200 na chave 2");
var resultado = dic3.TryAdd(2, 200);
Console.WriteLine("Elemento foi incluido? " + resultado);

Console.WriteLine("\nIncluindo o elemento na chave 7 caso esteja vazia");
if (!dic3.ContainsKey(7))
{
    dic3.Add(7, 7000);
    Console.WriteLine(dic3[7]);
}

Console.WriteLine("\nUsando containsValue para procurar se o valor 7000 existe no dicionario");

if (!dic3.ContainsValue(7000))
    Console.WriteLine("O valor existe no dicionário.");

Console.WriteLine("\nUsando TryGetValue() para a chave 5");

if(dic3.TryGetValue(5, out int valor))
    Console.WriteLine("Valor para a chave 5 = " + valor);
else
    Console.WriteLine("Chave não encontrada");


Console.WriteLine("\nPercorrendo o dicionario e exibindo os itens (foreach)");

foreach (var item in dic3)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}

Console.WriteLine("\nOrdenando os elementos do dicionário(SortedDictionary/LINQ)");

//var dic3Ordenado = new SortedDictionary<int, int>(dic3);
var dic3Ordenado = dic3.OrderBy(x => x.Key);

foreach (var item in dic3Ordenado)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}