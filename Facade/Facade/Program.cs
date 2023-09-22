namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {


            BankFacade bank = new BankFacade();

            int pocketmoney = bank.Withdraw("12ABNA12345678", "1234", 75);




        }
    }
}