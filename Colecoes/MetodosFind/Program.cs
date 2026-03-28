Console.WriteLine("## Metodos de busca em listas ##\n");

List<string> frutas = new List<string>()
{
    "Uva", "Banana", "Pera", "Maçã", "Laranja", "Abacate", "Morango"
};

Console.WriteLine("\nFind");

var fruta1 = frutas.Find(f=> f.Contains("n"));
Console.WriteLine(fruta1);

Console.WriteLine("\nFindLast:");

var fruta2 = frutas.FindLast(i => i.Contains("n"));
Console.WriteLine(fruta2);

Console.WriteLine("\nFindIndex: ");

var fruta3 = frutas.FindIndex(i => i.Contains("n"));
Console.WriteLine(fruta3);

Console.WriteLine("\nFindLastIndex: ");

var fruta4 = frutas.FindLastIndex(i => i.Contains("n"));
Console.WriteLine(fruta4);

Console.WriteLine("\nFindAll: ");

var frutas5 = frutas.FindAll(i => i.Contains("n"));

foreach (var fruta in frutas5)
{
    Console.WriteLine(fruta);
}

Console.ReadKey();
