Console.WriteLine("## Value Task ##");

Console.WriteLine("Quando usar ValueTask?");
Console.WriteLine("1 - Quando o resultado da operação executada pelo metodo asincrono já estiver disponível no momento da espera");
Console.WriteLine("2 - Quando temos cenários assincronos no qual o armazenamento em buffer está presente");
Console.WriteLine("3 - Quando o resultado da operação for concluida de forma sincrona");

await MetodoSemRetornoAsync();

var resultado = await MetodoRetornaValorAsync(20);
Console.WriteLine($"Resultado: {resultado}");

Console.WriteLine("Informe o primeiro numero inteiro");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o segundo numero inteiro");
int num2 = Convert.ToInt32(Console.ReadLine());

var soma = await CalcularSomaAsync(num1, num2);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"\n {num1} + {num2} = {soma}");

static async ValueTask MetodoSemRetornoAsync()
{
    Console.WriteLine("Metodo que não retorna valor");
    await Task.Delay(2000);
}

static async ValueTask<int> MetodoRetornaValorAsync(int valor)
{
    Console.WriteLine("Metodo que retorna valor");
    await Task.Delay(2000);
    return valor * 2;
}

static async ValueTask<int> CalcularSomaAsync(int num1, int num2)
{
    if (num1 == 0 && num2 == 0)
    {
        return 0;
    }

    return await Task.Run(() => num1 + num2);
}