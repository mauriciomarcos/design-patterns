using FactoryMethod.Creator;
using FactoryMethod.Entities.Implementation;
using FactoryMethod.Entities.Interface;

namespace FactoryMethod.Factory
{
    internal class ProductFactory : ProductCreator
    {
        public override IProduct CreateProduct(int tipo)
        {
            switch (tipo)
            {
                case 1: return new Pizza();
                case 2: return new Lanche();
                default: return null;
            }
        }
    }
}