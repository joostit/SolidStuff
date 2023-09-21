using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class Car
    {


        private IEngine engine;

        public Car(IEngine engine)
        {
            this.engine = engine;
        }

        public void Start()
        {
            engine.Start();
        }

        public void Stop()
        {
            engine.Stop();
        }


    }
}
