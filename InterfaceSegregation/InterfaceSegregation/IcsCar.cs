using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    internal class IcsCar : Car
    {

        public int EngineDisplacement { get; set; }
        public string FuelType { get; set; }

        public void AddFuel(int liters) { }

        public void StartEngine() { }

    }
}
