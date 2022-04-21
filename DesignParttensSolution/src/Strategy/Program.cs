using Strategy.ConcreteStrategies;
using Strategy.Entities;
using System;

namespace Strategy
{
    class Program
    {
        static void Main()
        {
            var compra = new Compra(1500m);
            var strategyContext = new Context();

            strategyContext.SetStrategy(new ICMS());
            var valorCalculoICMS = strategyContext.Calcular(compra);

            strategyContext.SetStrategy(new IPI());
            var valorCalculoIPI = strategyContext.Calcular(compra);

            Console.WriteLine($"Valor original da compra: {compra.Valor}");
            Console.WriteLine($"Valor do ICMS: {valorCalculoICMS}");
            Console.WriteLine($"Valor do IPI: {valorCalculoIPI}");
        }
    }
}