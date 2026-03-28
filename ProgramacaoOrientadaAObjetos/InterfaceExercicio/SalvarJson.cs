namespace InterfaceExercicio
{
    internal class SalvarJson : ArquivoBase, ISalvar
    {
        public void Salvar()
        {
            Console.WriteLine("Salvar arquivo JSON");
        }

        public override void Nome()
        {
            Console.WriteLine("Definir nome JSON");
        }
    }
}
