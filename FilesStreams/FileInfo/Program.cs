Console.WriteLine("## FileInfo ##");

var caminhoOrigem = @"c:\dev\CS_Journey\teste.txt";
var caminhoDestino = @"c:\dev\teste.txt";
var caminhoCopia = @"c:\dev\CS_Journey\teste_copia.txt";

FileInfo arquivoOrigem = new FileInfo(caminhoOrigem);

Console.WriteLine("\nNome do arquivo: " + arquivoOrigem.Name);
Console.WriteLine("\nCaminho completo do arquivo: " + arquivoOrigem.FullName);

var diretorioPai = arquivoOrigem.Directory;
Console.WriteLine("\nNome do diretorio: " + diretorioPai.Name);

Console.WriteLine("Tamanho do arquivo: " + arquivoOrigem.Length + " bytes");

Console.WriteLine("\nUltima gravacao: " + arquivoOrigem.LastWriteTime);

if (arquivoOrigem.Exists)
{
    Console.WriteLine($"\nCopiando {caminhoOrigem} arquivo existe. Copiando para {caminhoCopia}");
    arquivoOrigem.CopyTo(caminhoCopia);
}
else
{
    Console.WriteLine($"\n{caminhoOrigem} não existe.");
}

Console.WriteLine($"\nMovendo {caminhoOrigem} para {caminhoDestino}");
arquivoOrigem.MoveTo(caminhoDestino);