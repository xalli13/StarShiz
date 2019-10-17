﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GameLogic.Architecture
{
    public class Ship
    {
        // Временно добавим некоторое количество комнат
        public readonly int RoomsLimit = 10;

        private readonly List<Room> rooms = new List<Room>();

        public IEnumerable<Room> Rooms
        {
            get { return rooms; }
        }

        public void CreateEmptyRooms(Factory factory)
        {
            for (var i = 0; i < RoomsLimit; i++)
            {
                rooms.Add(new Room(i, factory.ProduceBuilding(BuildingType.Empty)));
            }
        }

        public Room GetRoom(int index)
        {
            return rooms[index];
        }
    }
}