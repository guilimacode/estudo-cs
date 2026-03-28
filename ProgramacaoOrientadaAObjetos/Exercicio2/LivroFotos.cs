namespace Exercicio2
{
    internal class LivroFotos
    {
        public int NumPaginas { get; set; }

        public LivroFotos()
        {
            NumPaginas = 16;
        }

        public LivroFotos(int numPaginas)
        {
            NumPaginas = numPaginas;
        }

        public void ExibirNumPaginas()
        {
            Console.WriteLine("Numéro de paginas " + NumPaginas);
        }
    }
}
