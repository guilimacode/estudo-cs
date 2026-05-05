using System.Collections.ObjectModel;

Console.WriteLine("## ReadOnlyCollection ##");

var planetas = new List<string>()
{
    "Mercúrio", "Vênus", "Terra", "Marte"
};

var listaPlanetas = new ReadOnlyCollection<string>(planetas);

Console.WriteLine("Planetas não gasosos do sistema solar:");
foreach (var planeta in planetas)
{
    Console.WriteLine($"{planeta} ");
}

Console.WriteLine($"\n\nPlanetas na coleção: {listaPlanetas.Count}");

Console.Write("\nJupiter está na coleção? ");
Console.WriteLine(listaPlanetas.Contains("Jupiter") ? "Sim", "Não");

Console.WriteLine($"Planeta de indice 3: {listaPlanetas[3]}");

Console.WriteLine($"Indice do planeta Terra: {listaPlanetas.IndexOf("Terra")}");

//se alterar a lista original altera a lista somente leitura
