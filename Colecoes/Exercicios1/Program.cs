Console.WriteLine("## Coleções - Exercicio 1 ##\n");

string?[] frutas = new string?[] {
    "Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora"
};

Console.WriteLine("\n");
Exibir(frutas);

Console.WriteLine("Quantidade de elementos do array: " + frutas.Length);

frutas[2] = "Kiwi";
frutas[9] = "Caqui";

Console.WriteLine("\n");
Exibir(frutas);

frutas.Sort();
Console.WriteLine("\n");
Exibir(frutas);

Console.WriteLine("\n");

for (int i = frutas.Length - 1; i >= 0; i--)
{
    Console.WriteLine(frutas[i]);
}

Console.ReadKey();

static void Exibir(string?[] frutas)
{
    foreach (string? fruta in frutas)
    {
        Console.WriteLine(fruta);
    }
}