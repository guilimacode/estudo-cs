class ContaInvestimento : ContaCorrente
{
    public ContaInvestimento(int numero, string? titular) : base(numero, titular)
    {
    }

    public override void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor não pode ser menor ou igual a 0");
            return;
        }

        decimal juros = valor * 0.009m; // 0.9%
        decimal valorTotal = valor + juros;

        base.Depositar(valorTotal);
    }

    public override void Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor não pode ser menor ou igual a 0");
            return;
        }

        decimal imposto = valor * 0.001m; // 0.1%
        decimal totalSaida = valor + imposto;

        if (Saldo - totalSaida < 0)
        {
            Console.WriteLine("Erro: Saldo insuficiente para o saque + impostos.");
            return;
        }

        base.Sacar(totalSaida);
    }
}
