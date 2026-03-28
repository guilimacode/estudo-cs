namespace Exercicio1
{
    internal class Carro : IVeiculo
    {
        public int Combustivel { get; set; }
        public Carro(int combustivel = 0)
        {
            Combustivel = combustivel;
        }
        public void Dirigir()
        {
            if (Combustivel == 0)
            {
                Console.WriteLine("Sem gasolina!");
                return;
            }
            Console.WriteLine("Dirigindo o carro...");
            Combustivel -= 1;
        }

        public bool Abastecer(int quantidade)
        {
            if (quantidade >= 0)
            {
                Combustivel += quantidade;
                return true;
            }
            Console.WriteLine("Valor invalido!");
            return false;
        }
    }
}
