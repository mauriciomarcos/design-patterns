using FactoryMethod.Entities.Interface;
using System.Collections.Generic;

namespace FactoryMethod.Entities.Implementation
{
    internal class Pizza : IProduct
    {
        public string Nome => "Pizza";

        public IList<string> Ingredientes => new List<string>() { "Molho", "Oregano", "Azeitona", "Queijo", "Manjerição" };        
    }
}