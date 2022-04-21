using Strategy.Entities;

namespace Strategy.AbstractStrategy
{
    internal interface IImpostoStrategy
    {
        decimal Calcular(Compra compra);
    }
}