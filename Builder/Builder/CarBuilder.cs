using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class CarBuilder
    {


        private Car theCar = new Car();

        public CarBuilder()
        {
            Reset();
        }


        public void Reset()
        {
            theCar = new Car()
            {
                Color = "White",
                DoorCount = 5,
                GearBoxType = "Manual 6",
                SeatCount = 5
            };
        }


        public CarBuilder WithBigEngine()
        {
            if (!String.IsNullOrWhiteSpace(theCar.EngineType)) { throw new InvalidOperationException("Car already has an engine"); }
            theCar.EngineType = "8l W12";
            theCar.Power = 700;
            return this;
        }

        public CarBuilder WithSmallEngine()
        {
            if (!String.IsNullOrWhiteSpace(theCar.EngineType)) { throw new InvalidOperationException("Car already has an engine"); }
            theCar.EngineType = "1.2l koffiemolen";
            theCar.Power = 95;
            return this;
        }

        public CarBuilder HasThreeDoors()
        {
            theCar.DoorCount = 3;
            return this;
        }

        public CarBuilder HasFiveDoors()
        {
            theCar.DoorCount = 5;
            return this;
        }


        public Car Build()
        {
            ValidateConfiguration();

            Car doneCar = theCar;

            Reset();

            return doneCar;
        }



        private void ValidateConfiguration()
        {
            if (String.IsNullOrWhiteSpace(theCar.EngineType)) { throw new InvalidOperationException("Cannot build a car without an engine"); }
            if (theCar.Power == 0) { throw new InvalidOperationException("Cannot build a car with 0 HorsePower"); }
        }
    }
}
