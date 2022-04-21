using Strategy.AbstractStrategy;
using Strategy.Entities;

namespace Strategy.ConcreteStrategies
{
    internal class ICMS : IImpostoStrategy
    {
        public decimal Calcular(Compra compra)
        {
            return compra.Valor * 0.15m;
        }
    }
}