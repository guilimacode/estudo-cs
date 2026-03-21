Console.WriteLine("## Instrução IF ## \n");

Console.WriteLine("Cliente Especial (true/false)");
var resposta = Convert.ToBoolean(Console.ReadLine());

if (resposta)
{
    Console.WriteLine("Desconto de 10%");
}

Console.WriteLine("Informe a nota do aluno \t");
var nota = Convert.ToInt32(Console.ReadLine());

if (nota > 6)
{
    Console.WriteLine("Aluno aprovado");
}
else
{
    Console.WriteLine("Aluno reprovado");
}

Console.WriteLine("Informe o valor de x\t");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y \t");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("X é maior que y");
}
else if (x < y)
{
    Console.WriteLine("X é menor que y");
}
else
{
    Console.WriteLine("X é igual a y");
}


Console.ReadKey();
