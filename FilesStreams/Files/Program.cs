Console.WriteLine("## Arquivos ##");

//@ -> verbatim
string caminhoOrigem = @"c:\dev\CS_Journey\teste.txt";

//Criar arquivo
//File.Create(caminhoOrigem);

//Escreve, caso não exista, cria e escreve

try
{

    File.WriteAllText(caminhoOrigem, "Vinicius de Moraes \r\n");

    string novoTexto = "Que a tristeza te convença\r\nQue a saudade não compensa\r\nE que a ausência não dá paz\r\nE o verdadeiro amor de quem se ama\r\nTece a mesma antiga trama\r\nQue não se desfaz\r\n\r\nE a coisa mais divina\r\nQue há no mundo\r\nÉ viver cada segundo\r\nComo nunca mais...";

    File.AppendAllText(caminhoOrigem, novoTexto);

    //Lê o conteudo do arquivo
    Console.WriteLine("\nConteúdo e informações do arquivo:");
    string conteudo = File.ReadAllText(caminhoOrigem);
    Console.WriteLine(conteudo);

    Console.WriteLine($"\nUltima modificação feita em: {File.GetLastWriteTime(caminhoOrigem)}");
    Console.WriteLine($"Ultimo acesso feito em: {File.GetLastAccessTime(caminhoOrigem)}");
    string[] linhas = File.ReadAllLines(caminhoOrigem);

    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }

    var caminhoCopia = @"c:\dev\CS_Journey\testeCopia.txt";

    Console.WriteLine($"Copiando de {caminhoOrigem} para {caminhoCopia}");
    File.Copy(caminhoOrigem, caminhoCopia);

    string caminhoDestino = @"c:\dev\testeMove.txt";
    Console.WriteLine($"Movendo {caminhoOrigem} para {caminhoDestino}");
    File.Move(caminhoOrigem, caminhoDestino);

    Console.WriteLine($"Excluindo {caminhoOrigem}, {caminhoDestino} e {caminhoCopia}");

    File.Delete(caminhoOrigem);
    File.Delete(caminhoCopia);
    File.Delete(caminhoDestino);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

