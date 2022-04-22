using Singleton.ImplementationSingleton;
using System;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            var document = DocumentSingleton.Instance;
            var documento2 = DocumentSingleton.Instance;

            if (document.Equals(documento2))
                Console.WriteLine("Pattern Singleton executado com sucesso");
        }
    }
}