namespace Singleton.ImplementationSingleton
{
    internal class DocumentSingleton
    {
        private DocumentSingleton()
        { }

        private static DocumentSingleton instance;

        public static DocumentSingleton Instance
        {
            get 
            { 
                if (instance is null)
                {
                    instance = new DocumentSingleton();
                }

                return instance;
            }
        }
    }
}