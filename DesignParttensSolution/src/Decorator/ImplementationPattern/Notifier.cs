using System;

namespace Decorator.ImplementationPattern
{
    // Componente concreto (classe concreta que implementa um componente base) provê uma implementação padrão da operação a ser executada.
    // Pode haver diversas variações dessas classes concreta.
    internal class Notifier : INotifier
    {
        public void SendMessage()
        {
            Console.WriteLine("Notifier");
        }
    }
}