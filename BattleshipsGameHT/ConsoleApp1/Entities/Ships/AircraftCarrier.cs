using ConsoleApp1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities.Ships
{
    public class AircraftCarrier : Ship
    {
        public AircraftCarrier()
        {
            Name = "Aircraft Carrier";
            Width = 5;
            OccupationType = OccupationTypeEnum.Carrier;
        }
    }
}
