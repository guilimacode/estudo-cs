namespace Exercicio1
{
    internal interface IVeiculo
    {
        public int Combustivel { get; set; }
        void Dirigir();
        bool Abastecer(int quantidade);
    }
}
