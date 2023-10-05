namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            new CarBuilderRunner().Run();
        }
    }
}