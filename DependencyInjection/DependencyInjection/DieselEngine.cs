using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class DieselEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting diesel engine");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping diesel engine");
        }
    }
}
