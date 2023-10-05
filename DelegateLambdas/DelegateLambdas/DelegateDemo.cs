using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DelegateLambdas
{

    public delegate void MethodDelegate();


    /// <summary>
    /// 
    /// </summary>
    /// <param name="firstInput">First stuff</param>
    /// <param name="secondInput">Second stuff. Very special</param>
    /// <returns></returns>
    public delegate string CreatorDelegate(string firstInput, int secondInput);

    public delegate void DoStuffDelegate(int amountOfStuff);
        
    internal class DelegateDemo
    {



        public void Run()
        {


            CreatorDelegate function = CreateStuff;

            object bla = new object();

            (42).ToString();


            MethodDelegate theMethod = AwesomeMethod;
            CreatorDelegate creator = CreateStuff;

            // far, far away...
            creator.Invoke("bla", 5);


            DoSomething(a => Console.WriteLine($"Printing {a} for your please"));

        }


        private void DoSomething(DoStuffDelegate action)
        {
            Console.WriteLine("About to do something! Yaaaay!! :)");

            action.Invoke(3);

            Console.WriteLine("I'm done!");
        }


        public void AwesomeMethod()
        {
            // Cool stuff
        }


        private int Calculate(int a, int b)
        {
            return a + b;
        }


        public string CreateStuff(string inA, int inB)
        {
            return "";
        }



    }
}
