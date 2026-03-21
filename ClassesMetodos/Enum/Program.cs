Console.WriteLine("## Enum ##\n");

Console.WriteLine(DiasDaSemana.Domingo);

int domingo = (int)DiasDaSemana.Domingo;
int terca = (int)DiasDaSemana.Terca;

Console.WriteLine($"\n{DiasDaSemana.Domingo} vale: {domingo}");
Console.WriteLine($"\n{DiasDaSemana.Terca} vale: {terca}");

Console.WriteLine($"{Categorias.Moda} - {(int)Categorias.Moda}");
Console.WriteLine($"{Categorias.Automotivo} - {(int)Categorias.Automotivo}");
Console.WriteLine($"{Categorias.Artes} - {(int)Categorias.Artes}");
Console.WriteLine($"{Categorias.Bebidas} - {(int)Categorias.Bebidas}");
Console.WriteLine($"{Categorias.Livros} - {(int)Categorias.Livros}");
Console.WriteLine($"{Categorias.Brinquedos} - {(int)Categorias.Brinquedos}");

Console.WriteLine("\nSelecione a categoria teclando seu valor: ");
int valor = Convert.ToInt32(Console.ReadLine());

var nomeMembroEnum = (Categorias)valor;
Console.WriteLine($"\nVocê selecionou a categoria: {nomeMembroEnum.ToString()}");

Console.ReadKey();

