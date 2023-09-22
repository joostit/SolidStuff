namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            //AppSettings sets = new AppSettings();

            AppSettings.Instance.ConnectionString = "fsgdsfdf";

            AppSettings.Instance.ConnectionString = "ABC";

            AppSettings.Instance.ConnectionString = "DEF";

            AppSettings.Instance.ConnectionString = "ABGHIC";

            AppSettings.Instance.ConnectionString = "XYZ";
        }
    }
}