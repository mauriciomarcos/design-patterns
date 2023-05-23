using System;

namespace Decorator.ImplementationPattern
{
    internal class NotifyWhatsappDecorator : BaseNotifierDecorator
    {

        public NotifyWhatsappDecorator(INotifier notifier)
            : base(notifier)
        { }
        
        public override void SendMessage()
        {
            base.SendMessage();
            Console.WriteLine($"Concrete Decorator - NotifyWhatsappDecorator");
        }
    }
}