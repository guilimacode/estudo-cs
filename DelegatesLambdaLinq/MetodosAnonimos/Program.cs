Console.WriteLine("## Metodos Anonimos ##");

Imprimir imprimir = delegate (int valor)
{
    Console.WriteLine($"Método anonimo: {valor}");
};

imprimir(10);

List<string> nomes = new List<string>();
nomes.Add("Gui");
nomes.Add("Julia");
nomes.Add("Lucas");

string? resultado = nomes.Find(delegate (string nome)
{
    return nome.Equals("Lucas");
});

Console.WriteLine(resultado);

public delegate void Imprimir(int valor);
