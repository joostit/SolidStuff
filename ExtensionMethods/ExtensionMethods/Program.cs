namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ExtensionMethodRunner runner = new ExtensionMethodRunner();
            runner.Run();
        }
    }
}