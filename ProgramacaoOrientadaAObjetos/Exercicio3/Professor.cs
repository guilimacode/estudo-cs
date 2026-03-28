namespace Exercicio3
{
    internal class Professor : Pessoa
    {
        public Professor(string? nome) : base(nome) { }
        
        public void Explicar()
        {
            Console.WriteLine($"{Nome} está explicando.");
        }
    }
}
