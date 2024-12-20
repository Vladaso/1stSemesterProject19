﻿namespace WorldOfZuul
{
    public class Room
    {
        //Name for ROOM
        public string RoomName { get; private set; }
        public int id { get; private set; }

        //Long / detailed  Description for ROOM
        public string LongDescription { get; private set;}

        public Dictionary<string, Room> Exits { get; private set; } = new();

        public Room(int id, string roomName, string longDesc)
        {
            this.id = id;
            RoomName = roomName;
            LongDescription = longDesc;
        }
    

        //Code bellow asigns exits for Room class
        public void SetExits(Room? north, Room? east, Room? south, Room? west)
        {
            SetExit("north", north);
            SetExit("east", east);
            SetExit("south", south);
            SetExit("west", west);
        }

        //SetExit method will asign exits you want to be available in Room
        public void SetExit(string direction, Room? neighbor)
        {
            if (neighbor != null)
                Exits[direction] = neighbor;
        }

    }
}
