Console.WriteLine("## Arrays ##\n");

//declaração do Array

int[] numeros;

//alocando memoria
numeros = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

//formas de declarar

string[] nomes = new string[5] { "Guilherme", "Daniel", "Davi", "Carlos", "Vivian" };

string[] nomes1 = new string[] { "Guilherme", "Daniel", "Davi", "Carlos", "Vivian" };

string[] nomes2 = { "Guilherme", "Daniel", "Davi", "Carlos", "Vivian" };

//acessando os elementos de um array

Console.WriteLine(nomes[0]);
Console.WriteLine(numeros[4]);

//atribuindo valores pelo indice

int[] numeros1 = new int[3];

numeros1[0] = 4;
numeros1[1] = 5;
numeros1[2] = 8;

//acessando os elementos de um array com laço for

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Elemento de indice {i} -- {numeros[i]}");
}

Console.WriteLine("");

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Elemento de indice {i} -- {nomes[i]}");
}

//acessando elementos com laço foreach

Console.WriteLine("");

foreach (int numero in numeros)
{
    Console.WriteLine($"{numero} * 2 = {numero * 2}");
}

Console.WriteLine("");

foreach (string nome in nomes)
{
    Console.WriteLine(nome.ToUpper());
}

Console.ReadKey();