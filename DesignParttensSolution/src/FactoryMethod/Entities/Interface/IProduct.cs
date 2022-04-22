using System.Collections.Generic;

namespace FactoryMethod.Entities.Interface
{
    internal interface IProduct
    {
        string Nome { get; }
        IList<string> Ingredientes { get; }
    }
}