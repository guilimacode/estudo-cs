Console.WriteLine("## Lançando exceptions ##\n");

try
{
    A.ProcessarA();
}
catch (Exception ex)
{
    Console.WriteLine("\nTratando o erro em Main\n");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}
class A
{
    public static void ProcessarA()
    {
        try
        {
            B.ProcessarB();
        }
        catch (Exception ex)
        {
            throw ex; //Relançando para main reescrevendo a stacktrace
        }
    }
}

class B
{
    public static void ProcessarB()
    {
        try
        {
            C.ProcessarC();
        }
        catch (Exception)
        {
            throw; //Relaçando a exceção para A mantendo a stacktrace original"
        }
    }
}

class C
{
    public static void ProcessarC()
    {
        throw new NotImplementedException("Método não implementado");
    }
}
