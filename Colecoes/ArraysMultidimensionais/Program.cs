Console.WriteLine("## Arrays Bidimensionais ##\n");

int[,] a;

a = new int[2, 2];

a[0,0] = 0;
a[0,1] = 1;
a[1,0] = 3;
a[1,1] = 4;

Console.WriteLine(a[0,0]);
Console.WriteLine(a[0,1]);
Console.WriteLine(a[1,0]);
Console.WriteLine(a[1,1]);

// int[,] b = new int[2, 2] { { 20, 30 }, { 40, 50 } };
int[,] b = { { 20, 30 }, { 40, 50 } };


Console.WriteLine(b[0, 0]);
Console.WriteLine(b[0, 1]);
Console.WriteLine(b[1, 0]);
Console.WriteLine(b[1, 1]);

//acessando com laço for

int[,] n = {
            { 1, 4, 2 },
            { 3, 6, 8 },
            { 4, 7, 9 },
           };

for (int i = 0; i < n.GetLength(0); i++)
{
    Console.WriteLine("");
    for (int j = 0; j < n.GetLength(1); j++)
    {
        Console.Write($"{n[i, j]} ");
    }
}

//acessando com laço foreach

Console.WriteLine("\nForeach\n");

foreach (var x in n)
{
    Console.Write($"{x} ");
}

Console.ReadKey();