Console.WriteLine("## Modificador Sealed ##\n");


Console.ReadKey();

public class ClasseBase
{
    protected virtual void Metodo1()
    {
        Console.WriteLine("ClasseBase.Metodo1()");
    }

    protected virtual void Metodo2() {
        Console.WriteLine("ClasseBase.Metodo2()");
    }
}

public class Classe1 : ClasseBase {
    sealed protected override void Metodo1()
    {
        Console.WriteLine("Classe1.Metodo1()");
    }

    protected override void Metodo2()
    {
        Console.WriteLine("Classe1.Metodo2()");
    }
}

public class Classe2 : Classe1
{
    /*
    protected override void Metodo1()
    {
        Console.WriteLine("Classe2.Metodo1()");
    }
    */

    protected override void Metodo2()
    {
        Console.WriteLine("Classe2.Metodo2()");
    }
}