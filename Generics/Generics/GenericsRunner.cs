namespace Generics
{
    internal class GenericsRunner
    {


        internal void Run()
        {
            Box<int> myBox = new();

            myBox.Contents = 21;

            Console.WriteLine(myBox.Contents * 2);
        }

    }
}
