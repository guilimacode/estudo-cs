Console.WriteLine("## FileStream ##");

string caminho = @"c:\dev\teste.txt";

try
{
    using (FileStream fs = new FileStream (caminho, FileMode.Open, FileAccess.Read))
    {
        using(StreamReader leitor = new StreamReader (fs))
        {
            string? linha;

            while ((linha = leitor.ReadLine()) != null)
            {
                Console.WriteLine(linha);
            }
        }
    }
}
catch (IOException ex)
{
    Console.WriteLine(ex.Message);
}

