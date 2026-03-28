namespace UpcastingDowncasting
{
    internal class Forma
    {
        protected int xpos, ypos;
        public Forma(int x, int y)
        {
            xpos = x;
            ypos = y;
        }

        public virtual void Desenhar()
        {
            Console.WriteLine("Desenhar - Forma");
        }
    }
}
