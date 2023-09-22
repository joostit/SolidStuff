namespace AdapterProxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Engineering company!");

            CivilEngineeringCompany company = new();
            company.Run();

        }
    }
}