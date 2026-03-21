Console.WriteLine("## Propriedades ##\n");

Produto p1 = new();
p1.Nome = "Caderno";
p1.Preco = 10.00;
p1.EstoqueMinimo = 10;

p1.Exibir();

Console.ReadKey();

public class Produto
{
    private string? nome;
    public string? Nome 
    { get { return nome.ToUpper(); }
      set { nome = value; }
    }
    private double preco;
    public double Preco { 
        get {  return preco; }
        set 
        {
            if (value < 5.00)
                preco = 5.00;
            else
                preco = value;
            
        }
    }
    private double desconto;
    public double Desconto
    {
        get { return desconto; }
    }
    public double PrecoFinal
    { 
        get { return Preco - (Preco * Desconto); }
    }

    private int estoqueMinimo;
    public int EstoqueMinimo { 
        set { estoqueMinimo = value; }
    }

    public void Exibir()
    {
        Console.WriteLine($"Nome: {Nome} \nPreco: {Preco.ToString("c")} \nDesconto: {Desconto} \nEstoque: {estoqueMinimo}");
    }
}
