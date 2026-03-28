class ContaPoupanca : ContaCorrente {

    public ContaPoupanca(int numero, string? titular) : base(numero, titular)
    {
    }

    public override void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor não pode ser menor ou igual a 0");
            return;
        }

        decimal juros = valor * 0.005m; // 0.5%
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

        if (Saldo - valor < 0)
        {
            Console.WriteLine("A conta poupança não pode ficar negativada. Operação cancelada.");
            return;
        }

       base.Sacar(valor);
    }
}
