namespace HerancaComposicao
{
    internal class Humano : Animal
    {
        private readonly ComportamentoAndar _comportamentoAndar;

        public Humano(ComportamentoAndar comportamentoAndar)
        {
            _comportamentoAndar = comportamentoAndar;
        }

        public void Locomocao()
        {
            Console.WriteLine(nameof(Humano));
            _comportamentoAndar.Andar();
        }
    }
}
