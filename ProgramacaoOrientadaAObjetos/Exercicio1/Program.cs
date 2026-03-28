using Exercicio1;

Console.WriteLine("## POO - Exercicio 1 ##\n");

IVeiculo carro = new Carro();

Console.WriteLine("Digite o quanto deseja abastecer: ");
int quantidadeAbastecer = Convert.ToInt32(Console.ReadLine());
carro.Abastecer(quantidadeAbastecer);

carro.Dirigir();
carro.Dirigir();

Console.ReadKey();
