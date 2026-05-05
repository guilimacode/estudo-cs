Console.WriteLine("\n### SortedDictionary ###");

var brics = new SortedDictionary<int, string>()
{
    {10, "Brasil"},
    {30, "India"},
    {20, "China"},
    {40, "Russia"},
};

Console.WriteLine("\nIncluindo o elemento de chave = 70 e valor - Africa do Sul");

if (brics.ContainsKey(70))
    Console.WriteLine("Chave já existe");
else
    brics.Add(70, "África do Sul");

Console.WriteLine($"\nNumero de pares de chaves(elementos) no dicionario : {brics.Count}");

Console.WriteLine("\nAcessando elemento pela chavve -> brics[20]");
var valor = brics[20];

Console.WriteLine("\nAlterando valor da chave 20 para Argentina -> brics[20] = Argentina");

brics[20] = "Argentina";

Console.WriteLine("\nRemovendo a chave 20");
brics.Remove(20);

Console.WriteLine("\nVerificando se existe a chave 30 com ContainsKey --> " + brics.ContainsKey(30));
Console.WriteLine("\nVerificando se existe o valor Chile com ContainsValue --> " + brics.ContainsValue("Chile"));

Console.WriteLine("\nPercorrendo o SortedDictionary");

foreach (var item in brics)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}