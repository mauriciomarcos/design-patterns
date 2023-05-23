using System;

namespace Decorator.ImplementationPattern
{   
    // A classe Decorator Base implementa a mesma interface do componente principal (representado pela classe Notifier).
    // O propósito primário desta classe é definir uma camada de empacotamento (envólucro) para todas implementações concretas do Decorator.
    // A implementação padrão desta classe inclui um campo encapsulado para armazenar um componente que impelemte a interface INotifier e inicializá-lo.
    internal abstract class BaseNotifierDecorator : INotifier
    {
        protected INotifier _notifier;

        protected BaseNotifierDecorator(INotifier notifier) => _notifier = notifier;

        // O Decorator base delega todo o trabalho para o componente envelopado.
        public virtual void SendMessage()
        {
            if (_notifier is not null)
                _notifier.SendMessage();
            else
                Console.WriteLine("Envio mensagem padrão - BaseNotifierDecorator");
        }
    }
}