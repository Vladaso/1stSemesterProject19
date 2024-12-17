using System;
using System.Collections.Generic;

namespace WorldOfZuul
{
    public class Map
    {
        private Game game;
        private HashSet<int> visitedRooms;
        private Dictionary<(int x, int y), char> map;
        private const int ROOM_WIDTH = 15;
        private const int ROOM_HEIGHT = 8;
        private const int ROOM_SPACING = 4;

        public Map(Game game)
        {
            this.game = game;
            this.visitedRooms = new HashSet<int>();
            this.map = new Dictionary<(int x, int y), char>();
        }

        public void DisplayMap()
        {
            ConsoleUtils.ClearConsole();
            if (!game.inventory.HasItem("Red Pearl"))
            {
                Console.WriteLine("You do not have this power yet. The Red Pearl is needed for this.");
                return;
            }
            Console.WriteLine("Look for the @ symbol to find your current location.");

            map.Clear();
            visitedRooms.Clear();

            int startX = 0, startY = 0;
            DrawRoomRecursive(0, startX, startY);

            PrintMap();
        }

        private void DrawRoomRecursive(int roomId, int x, int y)
        {
            if (visitedRooms.Contains(roomId)) return;

            visitedRooms.Add(roomId);
            DrawRoom(roomId, x, y);

            foreach (var edge in game.edges)
            {
                int nextRoom = -1;
                int nextX = x, nextY = y;

                if (edge.con1start == roomId && !visitedRooms.Contains(edge.con1end))
                {
                    nextRoom = edge.con1end;
                    GetNextCoordinates(edge.direction1, ref nextX, ref nextY);
                    DrawEdge(x, y, edge.direction1);
                }
                else if (edge.con1end == roomId && !visitedRooms.Contains(edge.con1start))
                {
                    nextRoom = edge.con1start;
                    GetNextCoordinates(edge.direction1, ref nextX, ref nextY);
                    DrawEdge(x, y, edge.direction1);
                }

                if (nextRoom != -1)
                {
                    DrawRoomRecursive(nextRoom, nextX, nextY);
                }
            }
        }

        private void DrawRoom(int roomId, int x, int y)
        {
            string roomName = game.rooms[roomId].RoomName;

            for (int i = 0; i <= ROOM_WIDTH; i++)
            {
                map[(x + i, y)] = '-';
                map[(x + i, y + ROOM_HEIGHT)] = '-';
            }
            for (int i = 0; i <= ROOM_HEIGHT; i++)
            {
                map[(x, y + i)] = '|';
                map[(x + ROOM_WIDTH, y + i)] = '|';
            }
            map[(x, y)] = '+';
            map[(x + ROOM_WIDTH, y)] = '+';
            map[(x, y + ROOM_HEIGHT)] = '+';
            map[(x + ROOM_WIDTH, y + ROOM_HEIGHT)] = '+';

            int nameStart = x + 1 + (ROOM_WIDTH - roomName.Length) / 2;
            for (int i = 0; i < roomName.Length && i + nameStart < x + ROOM_WIDTH; i++)
            {
                map[(nameStart + i, y + ROOM_HEIGHT / 2)] = roomName[i];
            }
            if(roomId == game.player.Position)
            {
                map[(x + ROOM_WIDTH / 2, y + ROOM_HEIGHT / 2 +2)] = '@';
            }
        }

        private void DrawEdge(int x, int y, string direction)
        {
            switch (direction)
            {
                case "north":
                    for (int i = 1; i <= ROOM_SPACING; i++) map[(x + ROOM_WIDTH / 2, y - i)] = '|';
                    break;
                case "south":
                    for (int i = 1; i <= ROOM_SPACING; i++) map[(x + ROOM_WIDTH / 2, y + ROOM_HEIGHT + i)] = '|';
                    break;
                case "east":
                    for (int i = 1; i <= ROOM_SPACING; i++) map[(x + ROOM_WIDTH + i, y + ROOM_HEIGHT / 2)] = '-';
                    break;
                case "west":
                    for (int i = 1; i <= ROOM_SPACING; i++) map[(x - i, y + ROOM_HEIGHT / 2)] = '-';
                    break;
            }
        }

        private void GetNextCoordinates(string direction, ref int x, ref int y)
        {
            switch (direction)
            {
                case "north": y -= (ROOM_HEIGHT + ROOM_SPACING); break;
                case "south": y += (ROOM_HEIGHT + ROOM_SPACING); break;
                case "east": x += (ROOM_WIDTH + ROOM_SPACING); break;
                case "west": x -= (ROOM_WIDTH + ROOM_SPACING); break;
            }
        }

        private void PrintMap()
        {
            int minX = int.MaxValue, minY = int.MaxValue;
            int maxX = int.MinValue, maxY = int.MinValue;

            foreach (var key in map.Keys)
            {
                minX = Math.Min(minX, key.x);
                minY = Math.Min(minY, key.y);
                maxX = Math.Max(maxX, key.x);
                maxY = Math.Max(maxY, key.y);
            }

            for (int y = minY; y <= maxY; y++)
            {
                for (int x = minX; x <= maxX; x++)
                {
                    if (map.ContainsKey((x, y)))
                        Console.Write(map[(x, y)]);
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}
