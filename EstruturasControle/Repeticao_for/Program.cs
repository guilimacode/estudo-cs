Console.WriteLine("## Estrutura de repetição for");

int resultado, numero;

Console.WriteLine("Informe o número inteiro: \t");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    for (int i = 0; i <= 10; i++)
    {
        resultado = numero * i;
        Console.WriteLine($"{numero} X {i} = {resultado}");
    }
}
else
{
    Console.WriteLine("Número inválido");
}


Console.ReadKey();