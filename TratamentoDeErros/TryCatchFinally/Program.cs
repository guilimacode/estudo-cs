Console.WriteLine("## Try-Catch-Finally ##\n");

try
{
    Console.WriteLine("\nInforme o dividendo");
    int dividendo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nInforme o divisor");
    int divisor = Convert.ToInt32(Console.ReadLine());

    int resultado = (dividendo / divisor);
    Console.WriteLine($"{dividendo} / {divisor} = {resultado}");
}
catch (FormatException)
{
    Console.WriteLine($"\nInforme um valor inteiro");
}
catch (OverflowException)
{
    Console.WriteLine($"\nInforme um valor inteiro entre 1 e 999999");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Não existe divisão por zero. Tente novamente.");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

// Exceptions mais gerais por ultimo

Console.ReadKey();
