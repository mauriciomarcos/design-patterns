using FactoryMethod.Entities.Interface;

namespace FactoryMethod.Creator
{
    internal abstract class ProductCreator
    {
        public abstract IProduct CreateProduct(int tipo);
    }
}