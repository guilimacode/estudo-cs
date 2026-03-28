Console.WriteLine("## List<T> ##\n");

//declarar uma coleção do tipo List<T>

var lista = new List<string>();

List<int> lista2 = new List<int>();

var lista3 = new List<string>()
{
    "Guilherme", "Julia", "Pedro"
};

//incluindo elementos no final da lista

lista.Add("Teste");
lista2.Add(20);
lista3.Add("Amanda");

//incluindo elemento em uma posição atraves do indice

lista3.Insert(2, "Vivian");

//incluindo uma coleção no final da lista

string[] alunas = new string[5] { "Emily", "Rayssa", "Isabela", "Maria", "Andressa" };
lista3.AddRange(alunas);

//incluindo coleção na lista na posição especificada

string[] alunos = new string[5] { "Gustavo", "Nicolas", "Michel", "Samuel", "Vitor" };
lista3.InsertRange(3, alunos);

//removendo primeira ocorrencia de um elemento

lista3.Remove("Pedro");

//removendo o elemento no indice especificado

lista3.RemoveAt(1);

//removendo um numero definido de elementos a partir de um indice

lista3.RemoveRange(0, 2);

//acessando elementos da lista

var primeiro = lista3[0];
var terceiro = lista3[2];

//alterando elementos diretamente

lista3[0] = "Guilherme";

//iterando com laço for

for (int i =0; i < lista3.Count; i++)
{
    Console.WriteLine(lista3[i]);
}

//verificar se elemento está presente na coleção

var res = lista3.Contains("Pedro"); //False
var res2 = lista3.Contains("Guilherme"); //True

//ordenar na ordem ascendente usando algoritmo quicksort (apenas em lista de elementos do mesmo tipo)

lista3.Sort();
Console.WriteLine("\nLista de alunos ordenada: \n");

ExibeLista(lista3);

//limpar a lista sem diminuir a capacidade

lista3.Clear();
Console.WriteLine("\nLista de alunos após limpeza: \n");
ExibeLista(lista3);

static void ExibeLista(List<string> lista3)
{
    foreach (var item in lista3)
    {
        Console.WriteLine(item);
    }
}