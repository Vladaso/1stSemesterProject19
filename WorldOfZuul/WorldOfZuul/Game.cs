namespace WorldOfZuul
{
    public class Game
    {
        private Room[]? rooms;
        private Edge[]? edges;
        private Room? previousRoom;
        private Room? currentRoom;
        private RoomArt roomArt;
        public Game()
        {
            roomArt = new RoomArt();
            CreateRooms();
            CreateEdges();
        }

        private void CreateRooms()
        {
            rooms[0] = new Room(0, "Outside", "You are outside");
            rooms[1] = new Room(1, "Inside", "You are inside");
            //More rooms
        }

        private void CreateEdges(){
            edges[0] = new Edge(0, 1, "north");
        }

        public void Play()
        {
            Parser parser = new();

            bool continuePlaying = true;
            while (continuePlaying)
            {
                Console.Clear();
                //Place for Screen Drawing

                string input = parser.ReadAction(); // necessary side effect - prints "Invalid Action" if invalid and asks again


                Action? action = parser.GetAction(input);

                action.Execute();

            }

            Console.WriteLine("Thank you for playing World of Zuul!");
        }
    }
}
