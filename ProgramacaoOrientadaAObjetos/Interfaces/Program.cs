Console.WriteLine("## Interfaces ##\n");

Demo d = new Demo();
d.Nome = "Teste";
d.Desenhar();
d.Pintar();

Console.ReadKey();

interface IControle
{

    //Não pode ter construtor nem metodos de instancia

    string? Nome { get; set; }
    void Desenhar(); //obrigado a implementar
    public void Exibir() //não precisa implementar
    {
        Console.WriteLine("...");
    }
    
}

interface IGrafico
{
    void Pintar();
}

public class Demo : IControle, IGrafico
{
    public string? Nome { get; set; }
    public void Desenhar()
    {
        Console.WriteLine("Desenhando");
    }

    public void Pintar()
    {
        Console.WriteLine("Pintando");
    }
}
