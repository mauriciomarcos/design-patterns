using Strategy.AbstractStrategy;
using Strategy.Entities;

namespace Strategy.ConcreteStrategies
{
    internal class IPI : IImpostoStrategy
    {
        public decimal Calcular(Compra compra)
        {
            return compra.Valor * 0.27m;
        }
    }
}