Console.WriteLine("## Expressões Lambda ##");

List<string> nomes = new List<string>();
nomes.Add("Gui");
nomes.Add("Julia");
nomes.Add("Lucas");

string? resultado = nomes.Find(nome => nome.Equals("Gui"));

Console.WriteLine(resultado);
