﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameLogic.Architecture
{
    public class Room
    {
        public readonly int Index;

        // каждая комната является пристанищем для строения
        public Building Building { get; set; }

        public Room(int index, Building building)
        {
            Index = index;

            Building = building;
        }
    }
}
