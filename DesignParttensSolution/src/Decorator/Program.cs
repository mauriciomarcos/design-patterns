using Decorator.ImplementationPattern;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var component = new Notifier();
      
            // Instanciando a classe Decorator concreta com implementação composta.
            var smsDecorator = new NotifySmsDecorator(component);
            var wppDecorator = new NotifyWhatsappDecorator(smsDecorator);

            wppDecorator.SendMessage();
        }
    }
}