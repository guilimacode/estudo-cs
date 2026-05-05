Console.WriteLine("## Directory ##");

var caminhoDiretorio = @"c:\dev\teste";

try
{
    if (!Directory.Exists(caminhoDiretorio))
    {
        Directory.CreateDirectory(caminhoDiretorio);
        Console.WriteLine($"O diretório {caminhoDiretorio} criado com sucesso");
    }
    else
        Console.WriteLine($"O diretório {caminhoDiretorio} já existe");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
