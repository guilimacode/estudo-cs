namespace HerancaTipos
{
    internal class Quadrado : Forma, ICusto
    {
        public int GetArea()
        {
            return (Lado * Lado);
        }

        public int GetCusto(int area)
        {
            return area * 10;
        }
    }
}
