using System.Threading.Channels;

namespace Exercicio3
{
    internal class Aluno : Pessoa
    {
        public Aluno(string? nome) : base(nome) { }
        
        public void Estudar()
        {
            Console.WriteLine($"{Nome} está estudando.");
        }
    }
}
