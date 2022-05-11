﻿using ConsoleApp1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities.Ships
{
    public class Submarine : Ship
    {
        public Submarine()
        {
            Name = "Submarine";
            Width = 3;
            OccupationType = OccupationTypeEnum.Submarine;
        }
    }
}
