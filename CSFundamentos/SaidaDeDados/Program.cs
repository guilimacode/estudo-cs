Console.WriteLine("## Saida de Dados ##\n");

int idade = 25;
string nome = "Maria";
Console.Write(nome);
Console.Write(idade);
Console.WriteLine();

//Escreve na mesma linha 'Maria tem 25 anos'
Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" anos ");
Console.WriteLine();
Console.WriteLine("-----concatenação----------");

//usar a concatenação : usando o operador +
Console.WriteLine(nome + " tem " + idade + " anos");
Console.Write(nome + " tem " + idade + " anos");
Console.WriteLine();
Console.WriteLine("-----interpolação-----------");
//usa a interpolação de strings : $ -> a interpolação {}
Console.WriteLine($"{nome} tem {idade} anos");

Console.WriteLine("-----place holders-----------");
//usar place holders : usa {} com numeração com inicio em zero 
Console.WriteLine("{0} tem {1} anos", idade, nome);


string local = "c:\\dados\\poesias.txt";
string frase = "Ele falou:\"Não fui eu\"";

string pizza = "\nPizza\nde\nMussarela";
string bolo = "\nBolo\tde\tChocolate";

Console.WriteLine(pizza);
Console.WriteLine(bolo);

Console.ReadKey();
