namespace Strategy.Entities
{
    internal sealed class Compra
    {
        public Compra(decimal valor)
        {
            Valor = valor;
        }

        public decimal Valor { get; private set; }
    }
}