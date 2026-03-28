using ClassesAbstratas;

Console.WriteLine("## Classes abstratas ##\n");

Quadrado q = new Quadrado();
Console.WriteLine("Informe a cor do quadrado: ");
q.Cor = Console.ReadLine();

Console.WriteLine("Informe o valor do lado do quadrado: ");
q.Lado = Convert.ToInt32(Console.ReadLine());

q.CalcularArea();
q.CalcularPerimetro();

Console.WriteLine($"Cor: {q.Cor} \nÁrea: {q.Area} \nPerimetro: {q.Perimetro}");

Console.ReadKey();