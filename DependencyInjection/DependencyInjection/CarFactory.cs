using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class CarFactory
    {

        public void Run()
        {

            List<Car> cars = new List<Car>();

            for (int i = 0; i < 100; i++)
            {
                IEngine engine;


                if (int.IsEvenInteger(i))
                {
                    engine = new GasolineEngine();
                }
                else
                {
                    engine = new DieselEngine();
                }


                Car aCar = new Car(engine);

                cars.Add(aCar);
            }


        }

    }
}
