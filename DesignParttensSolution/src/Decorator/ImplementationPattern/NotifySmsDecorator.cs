using System;

namespace Decorator.ImplementationPattern
{   
    // A classe Decorator concreta envelopa o objeto envolvido e altera o seu resultado de alguma forma.
    internal class NotifySmsDecorator : BaseNotifierDecorator
    {
        public NotifySmsDecorator(INotifier notifier) 
            : base(notifier)
        { }

        public override void SendMessage()
        {
            base.SendMessage();
            Console.WriteLine($"Concrete Decorator - NotifySmsDecorator");
        }
    }
}