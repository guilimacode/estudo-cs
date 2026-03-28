namespace UpcastingDowncasting
{
    internal class Circulo : Forma
    {
        public Circulo(int x, int y) : base(x, y) { }

        public override void Desenhar()
        {
            Console.WriteLine("Desenhar - Circulo");
        }

        public void PintarCirculo()
        {
            Console.WriteLine("Pintar o circulo");
        }
    }
}
