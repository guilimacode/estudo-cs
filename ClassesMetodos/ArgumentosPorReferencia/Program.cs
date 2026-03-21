Console.WriteLine("## Argumentos por referência - out ##");

Console.WriteLine("Informe o raio do circulo");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new();

double circuferencia = circulo.CalculaAreaPerimetro(raio, out double area);
Console.WriteLine("Perimetro da Circuferencia " + circuferencia);
Console.WriteLine("Área da Circuferencia " + area);

Console.ReadKey();

public class Circulo
{
    public double CalculaAreaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}
