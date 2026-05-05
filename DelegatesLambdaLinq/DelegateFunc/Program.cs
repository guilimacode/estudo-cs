Console.WriteLine("## Delegate Func ##");

Console.WriteLine("Informe um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());

Func<double, double> raizQuadrada = x => Math.Sqrt(x);
double resultado = raizQuadrada(numero);

Console.WriteLine($"\nA raiz quadrada de {numero} é {resultado}");
