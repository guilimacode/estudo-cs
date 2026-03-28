using System.Collections;

Console.WriteLine("## ArrayList ##\n");

//atualmente é pouco utilizada pois nem sempre oferece melhor desempenho, a recomendação é utilizar List

//inicializando ArrayList
var lista = new ArrayList() { "Guilherme", 23, true, 39.3 };

//adicionando elementos no final da lista com Add

ArrayList lista2  = new ArrayList();
lista2.Add("Guilherme");
lista2.Add(23);
lista2.Add(true);
lista2.Add(39.3);

//adicionando elementos em um local especifico com insert

lista2.Insert(3, 1.76);

//adicionando coleção de elementos ao final da lista

var lista3 = new ArrayList() { "Maria", 6, true };
int[] array1 = { 1, 2, 3, 4, 5 };

lista3.AddRange(array1);

//adicionando coleção no indice especificado

int[] array2 = { 3, 5, 0, 4 };

lista3.InsertRange(3, array2);

//removendo a primeira ocorrencia de um elemento

var lista4 = new ArrayList() {"Ana", 5, true, " ", null, 1.1, "Zé", 3, 9, 0};

lista4.Remove(null);

//removendo o elemento no indice especificado

lista4.RemoveAt(4);

//removendo um numero especifico de elementos a partir de um indice

lista.RemoveRange(0, 2); // <-- remove dois elementos a partir do indice 0

//verificando se o elemento está na ArrayList

var lista5 = new ArrayList() { 10, "teste", null, true };

var res1 = lista5.Contains(true); //True
var res2 = lista5.Contains(10);  //True
var res3 = lista.Contains(49); //False

//Ordenando elementos utilizando o algoritmo Quicksort

var nomes = new ArrayList() { "Guilherme", "Antonio", "Pedro", "Gabriel", "Alessandro"};
nomes.Sort();

//Removendo todos os elementos sem alterar a capacidade

nomes.Clear();

Console.ReadKey();
