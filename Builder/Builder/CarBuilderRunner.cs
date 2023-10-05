namespace Builder
{
    internal class CarBuilderRunner
    {


        internal void Run()
        {
            CarBuilder builder = new CarBuilder();

            Car easyBuildCar = builder
                .HasFiveDoors()
                .WithBigEngine()
                .Build();

            Car secondCar = builder
                .HasThreeDoors()
                .Build();

        }


        private void DoLotsOfTediousWorkToBuildACar()
        {

            Car myCar = new Car();
            myCar.Color = "Red";
            myCar.DoorCount = 3;
            myCar.EngineType = "Inline 4";

            // Make mistakes by adding code before car is fully initialized

            myCar.GearBoxType = "Manual 6";
            myCar.Power = 95;
            myCar.SeatCount = 5;


            Car myCar2 = new Car()
            {
                Color = "Red",
                DoorCount = 3,
                EngineType = "Inline 4",
                GearBoxType = "Manual 6",
                Power = 95,
                SeatCount = 5,
            };

        }
    }
}