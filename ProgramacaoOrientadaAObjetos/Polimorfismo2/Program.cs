using Polimorfismo2;
Console.WriteLine("## Polimorfismo Estático - Sobrecarga ##\n");

Calcular calc = new Calcular();

Console.WriteLine(calc.Somar(30, 40));
Console.WriteLine(calc.Somar(20, 40, 50));

Console.ReadKey();
