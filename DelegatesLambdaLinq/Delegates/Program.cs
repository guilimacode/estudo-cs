Console.WriteLine("## Delegates ##\n");

DelegateCalculadora calc = new DelegateCalculadora(Calculadora.Somar);
var resultado = calc.Invoke(20, 30);
Console.WriteLine($"Soma = {resultado}");

calc = Calculadora.Multiplicar;
Console.WriteLine($"Produto = {calc.Invoke(10, 20)}");

calc = (float x, float y) => Calculadora.Subtrair(x, y);
Console.WriteLine($"Diferença = {calc.Invoke(10, 20)}");

Console.ReadKey();

// Top level statements - delegate precisa ficar de fora do main

public delegate float DelegateCalculadora(float x, float y);