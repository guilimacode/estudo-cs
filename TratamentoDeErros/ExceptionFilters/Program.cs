Console.WriteLine("## Filtros de exceção ##");

try
{
    Console.WriteLine("\nInforme o dividendo");
    int dividendo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\nInforme o divisor");
    int divisor = Convert.ToInt32(Console.ReadLine());
    int resultado = (dividendo / divisor);
    Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}\n");
}
catch (DivideByZeroException) when (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
{
    Console.WriteLine("\nHoje é sexta-feira e não capturamos essas exceções por motivos obvíos");
}
catch (Exception ex) when (ex.Message.Contains("format"))
{
    Console.WriteLine("Filtro de exceção com format");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.StackTrace);
}


