using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Enums
{
    public enum OccupationTypeEnum
    {
        [Description("o")]
        Empty = 0,

        [Description("B")]
        Battleship = 1,

        [Description("C")]
        Cruiser = 2,

        [Description("D")]
        Destroyer = 3,

        [Description("S")]
        Submarine = 4,

        [Description("A")]
        Carrier = 5,

        [Description("X")]
        Hit = 6,

        [Description("M")]
        Miss = 7
    }
}
