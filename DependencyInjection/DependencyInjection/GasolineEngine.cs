using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class GasolineEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting gas engine");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping gas engine");
        }
    }
}
