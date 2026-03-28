namespace Exercicio3
{
    internal class Pessoa
    {
        public string? Nome { get; set; }

        public Pessoa(string? nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return $"Nome da Pessoa: {Nome}";
        }
    }
}
