class ContaCorrente
{
    public int Numero { get; set; }
    public string? Titular { get; set; }
    public decimal Saldo { get; protected set; } = 0m;
    public virtual decimal TaxaJuros { get; } = 0m;

    public ContaCorrente(int numero, string? titular) { 
        Numero = numero;
        Titular = titular;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"\nTitular: {Titular} \nNúmero: {Numero} \nSaldo: { Saldo}");
    }
    public virtual void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor não pode ser menor ou igual a 0");
            return;
        }
        Saldo += valor + (valor * TaxaJuros);
        ExibirSaldo();
    }

    public virtual void Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor não pode ser menor ou igual a 0");
            return;
        }
        Saldo -= valor;
        ExibirSaldo();
    }

    protected void ExibirSaldo()
    {
        Console.WriteLine($"\n({Numero})Saldo atual: {Saldo:C}");
    }
}
