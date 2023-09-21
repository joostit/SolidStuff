namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarFactory factory = new CarFactory();
            factory.Run();
        }
    }
}