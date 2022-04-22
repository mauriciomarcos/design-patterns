using FactoryMethod.Factory;
using System;
using System.Linq;

namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escolha a opção de produto:");
            Console.WriteLine("1-(Pizza) ou 2-(Lanche)");

            var opcao = int.Parse(Console.ReadLine());
            var factory = new ProductFactory();

            var produtoEscolhido = factory.CreateProduct(opcao);

            Console.WriteLine($"Produto escolhido pelo usuário: {produtoEscolhido.Nome}");
            Console.WriteLine($"Ingredientes do produto: { string.Join(" | ", produtoEscolhido.Ingredientes.Select(p => p)) }" );
        }
    }
}