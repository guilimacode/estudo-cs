using OperadorAs;

Console.WriteLine("## Operador as ##\n");

Console.WriteLine("\nUpcasting\n");

Object carroObj = new Carro();

//try
//{
//    var x = (string)carroObj; //exception
//}
//catch (Exception ex)
//{
//    Console.WriteLine("\nA conversão falhou\n");
//    Console.WriteLine(ex.Message);
//	throw;
//}

var x = carroObj as string; 

if (x != null)
{
    Console.WriteLine("converteu de obj para string");
}
else
{
    Console.WriteLine("Não foi possivel converter, x é null");
}

Console.WriteLine("\nDowncasting\n");

Circulo circulo = new Circulo(20, 20);
Forma forma = circulo; // upcasting

if (forma is Circulo) //verifica se downcast é possivel
{
    Console.WriteLine("Converteu Forma para Circulo\n");
    var tipo = forma as Circulo;
    tipo?.PintarCirculo();
}
else 
{
    Console.WriteLine("Downscasting não é possível");
}

Console.ReadKey();

class Carro { }