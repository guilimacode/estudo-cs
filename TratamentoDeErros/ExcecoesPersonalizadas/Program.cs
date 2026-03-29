/* Recomendações:
 * Substituir a propriedade message para uma mensagem mais clara
 * substituir o metodo ToString() para log e depuracao
 * Deixar as condições de erro claras
 * Evitar exceptions fazendo tratamento preventivo no codigo
*/

Console.WriteLine("## Exceptions Personalizadas ##\n");
Conta conta1 = new Conta(100, "Maria", 199m);

try
{
    Console.WriteLine(conta1.ToString());
    conta1.Depositar(100);
    Console.WriteLine("Saldo: " + conta1.Saldo);
    conta1.Sacar(300);
    Console.WriteLine("Saldo: " + conta1.Saldo);
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.HelpLink);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}

public class Conta
{
    public int Numero {  get; set; }
    public string? Titular { get; set; }
    public decimal Saldo { get; set; }

    public Conta(int numero, string? titular, decimal saldo)
    {
        Numero = numero;
        Titular = titular;
        Saldo = saldo;
    }

    public decimal Depositar(decimal valor)
    {
        Saldo += valor;
        Console.WriteLine("Depositou: " + valor);
        return Saldo;
    }

    public decimal Sacar(decimal valor)
    {
        if (Saldo < valor)
        {
            throw new SaldoInsuficienteException(valor, Saldo);
        }
        Saldo -= valor;
        Console.WriteLine("Sacou: " + valor);
        return Saldo;
    }

    public override string ToString()
    {
        return $"Conta: {Numero} : {Titular}\nSaldo - {Saldo}";
    }
}

public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException()
    {
    }

    public SaldoInsuficienteException(string? message) : base(message)
    {
    }

    public SaldoInsuficienteException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    public SaldoInsuficienteException(decimal saque, decimal saldo)
    :base($"\nException: Valor do saque {saque} é superior ao saldo {saldo}")
    { }
    
    public override string Message { get => "Saldo insuficiente para o valor do saque"; }

    public override string? HelpLink { get => "Info: www.google.com.br" ; }
}