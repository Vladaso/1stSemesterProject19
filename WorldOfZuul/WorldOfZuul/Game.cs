using System.Linq;

namespace WorldOfZuul
{

    public class Game
    {
        private List<Room> rooms;
        public List<Edge> edges { get; private set; }
        public List<Item> items { get; private set; }
        private RoomArt roomArt;
        private Parser parser = new Parser();
        public Player player { get; private set; } = new Player();
        private Action action;

        public Boolean continuePlaying = true;

        public Game()
        {
            roomArt = new RoomArt();
            rooms = new List<Room>();
            edges = new List<Edge>();
            items = new List<Item>();
            action = new Action(game: this); // So Action can encapsulate the game logic
            CreateRooms();
            CreateEdges();
            CreateItems();
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

        private void CreateItems(){
            items.Add(new Item(name:"Bubbles", description:"Frail bubbles stuck together.", x: 15, y: 10, roomNumber: 0, symbol: "🫧"));
            items.Add(new Item(name:"Key", description:"Hmm I wonder what this opens?", x: 15, y: 15, roomNumber: 1, symbol: "🔑"));
            items.Add(new Item(name:"Hamburger", description:"Mhmm burger.", x: 15, y: 15, roomNumber: 2, symbol: "🍔"));
            items.Add(new Item(name:"Balloon", description:"How come it doesn't pop?", x: 15, y: 15, roomNumber: 3, symbol: "🎈"));
            items.Add(new Item(name:"Guitar", description:"If only I could play", x: 15, y: 15, roomNumber: 4, symbol: "🎸"));
        }

        private char[] GetPossibleMoves(){
            List<char> possibleMoves = new List<char>();
            foreach (Edge edge in edges)
            {
                if(edge.con1start == player.Position){
                    possibleMoves.Add(Utils.DirectionToChar(edge.direction1));
                }
                else if(edge.con2start == player.Position){
                    possibleMoves.Add(Utils.DirectionToChar(edge.direction2));
                }
            }
            possibleMoves.Add('q');
            return possibleMoves.ToArray();
            // Should be extended to item actions
        }

        public void Play()
        {
            //One time screen initialization
            Screen screen = new Screen(37, 90); //Height, Width
            Inventory inventory = new Inventory();
            PollutionMeter pollutionMeter = new PollutionMeter();
            Quizer quizer = new Quizer();

            while (continuePlaying)
            {
                ConsoleUtils.ClearConsole();

                char[] possibleMoves = GetPossibleMoves();

                ActionBar actionBar = new ActionBar(possibleMoves);

                screen.SetScreenContent(rooms[player.Position].RoomName,
                inventory.ShowInventory(), 
                roomArt.Rooms[player.Position],
                actionBar.ToString(), 
                items.Where(item => item.RoomNumber == player.Position).ToList().FirstOrDefault());

                screen.Display();
                pollutionMeter.Draw();

                char input = parser.ReadAction(possibleMoves);

                action.Execute(input);
                if(pollutionMeter.IncreasePollution()){
                    quizer.AskQuestion();
                }
            }
        }

    }
}
