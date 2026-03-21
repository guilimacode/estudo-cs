using Exercicio1;
Console.WriteLine("## Exercícios Práticos - 1 ##");

Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110, 1);
chevrolet.Exibir();
chevrolet.Acelerar(chevrolet.Marca);

chevrolet.AumentarPotencia(chevrolet.Potencia);
Console.WriteLine("Potencia após passar por valor: " + chevrolet.Potencia);

chevrolet.AumentarPotencia(ref chevrolet.Potencia);
Console.WriteLine("Potencia após passar por referencia: " + chevrolet.Potencia);

chevrolet.AumentarPotenciaVelocidade(ref chevrolet.Potencia, out double velocidade);
Console.WriteLine("Velocidade: " + velocidade);

Carro ford = new("SUV", "Ford", "EcoSport", 2026, 120, 4);
ford.Exibir();
ford.Acelerar(ford.Marca);

ford.AumentarPotencia(ford.Potencia);
Console.WriteLine("Potencia após passar por valor: " + ford.Potencia);

ford.AumentarPotencia(ref ford.Potencia);
Console.WriteLine("Potencia após passar por referencia: " + ford.Potencia);

public class Carro
{
    public string Modelo;
    public string Montadora;
    public string Marca;
    private int ano;
    public int Ano {
        get { return ano; }
        set
        {
            if (value < 2000)
            {
                ano = 2000;
            }
            else if (value > 2022)
            {
                ano = 2022;
            }
            else
            {
                ano = value;
            }
        }
    }
    public int Potencia;
    public int Cor;
    public static double ValorIpva;

    public Carro(string? Modelo, string? Montadora, string? Marca, int Ano, int Potencia, int cor)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
        this.Cor = cor;
    }

    public Carro(string? Modelo, string? Montadora)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
    }

    static Carro()
    {
        ValorIpva = 4;
    }
    public void Acelerar(string Marca)
    {
        Console.WriteLine($"Acelerando o meu {Marca}\n");
    }

    public double VelocidadeMaxima(int Potencia)
    {
        return Potencia * 1.75;
    }

    public int AumentarPotencia(int Potencia)
    {
        return Potencia += 3;
    }

    public int AumentarPotencia(ref int Potencia)
    {
        return Potencia += 5;
    }

    public int AumentarPotenciaVelocidade(ref int Potencia, out double Velocidade)
    {
        Velocidade = Potencia * 1.75;
        return Potencia += 7;
    }

    public void Exibir()
    {
        Console.WriteLine("Modelo: " + this.Modelo);
        Console.WriteLine("Montadora: " + this.Montadora);
        Console.WriteLine("Marca: " + this.Marca);
        Console.WriteLine("Ano: " + this.Ano);
        Console.WriteLine("Cor: " + (CarroEnum)this.Cor);
        Console.WriteLine("Potência: " + this.Potencia);
        Console.WriteLine("Velocidade Máxima: " + VelocidadeMaxima(this.Potencia));
        Console.WriteLine("Valor IPVA: " + ValorIpva);
        Console.WriteLine("\n");
    }
}   
