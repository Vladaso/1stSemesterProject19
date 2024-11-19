using System.Linq;

namespace WorldOfZuul
{

    public class Game
    {
        private List<Room> rooms;
        private List<Edge> edges;
        private RoomArt roomArt;
        private Parser parser = new Parser();
        private Player player = new Player();
        private Action action;

        public Game()
        {
            roomArt = new RoomArt();
            rooms = new List<Room>();
            edges = new List<Edge>();
            action = new Action(edges, player);
            CreateRooms();
            CreateEdges();
        }

        private void CreateRooms()
        {
            rooms.Add(new Room(0, "Frog Room", "Placeholder"));
            rooms.Add(new Room(1, "Sealion Room", "Placeholder"));
            rooms.Add(new Room(2, "Whale Room", "Placeholder"));
            rooms.Add(new Room(3, "Cave Room", "Placeholder"));
            rooms.Add(new Room(4, "Bottle Room", "Placeholder"));
            rooms.Add(new Room(5, "Broom Room", "Placeholder"));
            rooms.Add(new Room(6, "Diamond Room", "Placeholder"));
            rooms.Add(new Room(7, "Pyramid room", "Placeholder"));
            rooms.Add(new Room(8, "Bag Room", "Placeholder"));
            rooms.Add(new Room(9, "Maze room", "Placeholder"));
        }

        private void CreateEdges(){
            edges.Add(new Edge(0, 1, "north"));
            edges.Add(new Edge(1, 2, "west"));
            edges.Add(new Edge(2, 8, "west"));
            edges.Add(new Edge(8, 9, "south"));
            edges.Add(new Edge(1, 3, "east"));
            edges.Add(new Edge(3, 4, "south"));
            edges.Add(new Edge(4, 5, "south"));
            edges.Add(new Edge(5, 6, "west"));
            edges.Add(new Edge(5, 7, "east"));

        }

        private char[] GetPossibleMoves(){
            List<char> possibleMoves = new List<char>();
            foreach (Edge edge in edges)
            {
                if(edge.con1start == player.Position){
                    possibleMoves.Add(DirectionToChar(edge.direction1));
                }
                else if(edge.con2start == player.Position){
                    possibleMoves.Add(DirectionToChar(edge.direction2));
                }
            }
            return possibleMoves.ToArray();
            // Sohuld be extended to item actions
        }

        public void Play()
        {
            bool continuePlaying = true;
            while (continuePlaying)
            {
                // Has to be done like this to clear the WHOLE console
                Console.Clear();
                Console.WriteLine("\x1b[3J");
                Console.Clear();

                //Place for Screen Drawing
                Console.WriteLine(rooms[player.Position].RoomName);
                Console.WriteLine(roomArt.Rooms[player.Position]); // Temporary for Now

                char[] possibleMoves = GetPossibleMoves();
                string[] directions = possibleMoves.Select(CharToDirection).ToArray();

                // Action Bar
                ActionBar actionBar = new ActionBar(directions);
                actionBar.Display();

                
                char input = parser.ReadAction(possibleMoves); // necessary side effect - prints "Invalid Action" if invalid and asks again
                if (input == 'q')
                {
                    continuePlaying = TerminateGame();
                    continue;
                } else
                {
                    action.MovePlayer(CharToDirection(input));
                }

                // Action? action = parser.GetAction(input);

                // action.Execute();
            }

        }

        private char DirectionToChar(string direction){
            if (direction == "north"){
                return 'w';
            }
            else if (direction == "south"){
                return 's';
            }
            else if (direction == "east"){
                return 'd';
            }
            else if (direction == "west"){
                return 'a';
            }
            else{
                throw new Exception("Invalid direction");
            }
        }
        private string CharToDirection(char direction){
            if (direction == 'w'){
                return "north";
            }
            else if (direction == 's'){
                return "south";
            }
            else if (direction == 'd'){
                return "east";
            }
            else if (direction == 'a'){
                return "west";
            }
            else{
                throw new Exception("Invalid direction");
            }
        }
        private void MovePlayer(string direction){
            foreach (Edge edge in edges){
                if(edge.con1start == player.Position&& edge.direction1 == direction){
                    player.Position = edge.con1end;
                    return;
                }
                else if(edge.con2start == player.Position && edge.direction2 == direction){
                    player.Position = edge.con2end;
                    return;
                }
            }
        }

        private bool TerminateGame(){
            Console.Clear();
            Console.WriteLine("                              . ");
            Console.WriteLine("Thank you for playing  ><(((º> ");
            Console.WriteLine();
            return false;
        }

    }
}
