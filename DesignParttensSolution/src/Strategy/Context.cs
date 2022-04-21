using Strategy.AbstractStrategy;
using Strategy.Entities;

namespace Strategy
{
    internal class Context
    {
        private IImpostoStrategy _impostoStrategy;

        public void SetStrategy(IImpostoStrategy impostoStrategy)
        {
            _impostoStrategy = impostoStrategy;
        }

        public decimal Calcular(Compra compra)
        {
            return _impostoStrategy.Calcular(compra);
        }
    }
}