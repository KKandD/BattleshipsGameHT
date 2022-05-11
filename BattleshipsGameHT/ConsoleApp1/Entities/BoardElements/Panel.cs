using ConsoleApp1.Enums;
using ConsoleApp1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities.BoardElements
{
    public class Panel
    {
        public OccupationTypeEnum OccupationType { get; set; }
        public Coordinates Coordinates { get; set; }

        public Panel(int row, int column)
        {
            Coordinates = new Coordinates(row, column);
            OccupationType = OccupationTypeEnum.Empty;
        }

        public string Status
        {
            get
            {
                return EnumHelper.Description(OccupationType);
            }
        }

        public bool IsOccupied
        {
            get
            {
                return OccupationType == OccupationTypeEnum.Battleship
                    || OccupationType == OccupationTypeEnum.Destroyer
                    || OccupationType == OccupationTypeEnum.Cruiser
                    || OccupationType == OccupationTypeEnum.Submarine
                    || OccupationType == OccupationTypeEnum.Carrier;
            }
        }

        public bool IsRandomAvailable
        {
            get
            {
                return (Coordinates.Row % 2 == 0 && Coordinates.Column % 2 == 0)
                    || (Coordinates.Row % 2 == 1 && Coordinates.Column % 2 == 1);
            }
        }
    }
}
