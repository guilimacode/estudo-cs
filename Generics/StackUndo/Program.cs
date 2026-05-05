Console.WriteLine("## Stack Undo ##");

EditorTexto editor = new EditorTexto();
Console.WriteLine("\nDigitando...\n");
editor.Digitarchar('s');
editor.Digitarchar('t');
editor.Digitarchar('a');
editor.Digitarchar('c');
editor.Digitarchar('q');
editor.Digitarchar('!');

Console.WriteLine("\nFazendo o Undo...\n");
editor.Undo();
editor.Undo();

Console.WriteLine("\nRedigitando...");
editor.Digitarchar('k');
editor.Digitarchar('!');

public class EditorTexto
{
    private Stack<char> _chars = new Stack<char>();
    private string TextoAtual => new string(_chars.Reverse().ToArray());

    public void Digitarchar(char c)
    {
        _chars.Push(c);
        Console.WriteLine($"Texto: {TextoAtual}");
    }

    public void Undo()
    {
        if(_chars.Count > 0)
        {
            _chars.Pop();
            Console.WriteLine($"Texto: {TextoAtual}");
        }
    }
}