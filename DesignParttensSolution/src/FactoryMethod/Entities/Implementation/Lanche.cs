using FactoryMethod.Entities.Interface;
using System.Collections.Generic;

namespace FactoryMethod.Entities.Implementation
{
    internal class Lanche : IProduct
    {
        public string Nome => nameof(Lanche);

        public IList<string> Ingredientes => new List<string>() { "Pão", "Hamburguer", "Queijo", "Tomate", "Alface" };
    }
}