namespace Decorator.ImplementationPattern
{    
    // O componente base (Interface ou Classe Abstrata) define as operações (métodos)
    // que podem ser alterados pelos Decorators.
    internal interface INotifier
    {
        void SendMessage();
    }
}