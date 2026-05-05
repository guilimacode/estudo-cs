Console.WriteLine("## Generics ##\n");
ClasseGenerica<int> objInt = new ClasseGenerica<int>();
ClasseGenerica<string> objString = new ClasseGenerica<string>();

objInt.Adicionar(10);
objInt.Adicionar(20);
objInt.Adicionar(30);
objInt.Adicionar(40);
objInt.Adicionar(50);

objString.Adicionar("A");
objString.Adicionar("B");
objString.Adicionar("C");
objString.Adicionar("D");
objString.Adicionar("E");

Console.WriteLine("Classe Generica do tipo int");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(objInt[i]);
}

Console.WriteLine("Classe Generica do tipo string");


for (int i = 0; i < 5; i++)
{
    Console.WriteLine(objString[i]);
}

public class ClasseGenerica<T>
{
    T[] obj = new T[5];
    int contador = 0;

    public void Adicionar(T item)
    {
        if (contador < 5)
        {
            obj[contador++] = item;
        }
    }

    public T this[int index]
    {
        get { return obj[index]; }
        set { obj[index] = value; }
    }
}