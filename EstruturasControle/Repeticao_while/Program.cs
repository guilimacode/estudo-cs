Console.WriteLine("## Estrutura de Repetição While ##\n");

int contador = 1;

Console.WriteLine("Digite um número maior que zero\t");
var numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine($"\n ## Tabuada do {numero} ##\n");
    while (contador < 11)
    {
        Console.WriteLine($"{numero} X {contador} = {numero * contador}");
        contador++;
    }
}
else
{
    Console.WriteLine("\nNúmero deve ser maior que zero!");
}

Console.ReadKey();