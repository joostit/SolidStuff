using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Car
    {

        public int SeatCount { get; set; }

        public int Power { get; set; }

        public string GearBoxType { get; set; } = string.Empty;

        public string Color { get; set; } = string.Empty;

        public string EngineType { get; set; } = string.Empty;

        public int DoorCount { get; set; }


    }
}
