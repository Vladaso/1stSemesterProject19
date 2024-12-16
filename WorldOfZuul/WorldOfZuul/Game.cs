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
        public List<NPC> npcs;
        public Inventory inventory = new Inventory();
        //One time screen initialization
        public Screen screen = new Screen(37, 90); //Height, Width

        public Boolean continuePlaying = true;

        public Game()
        {
            roomArt = new RoomArt();
            rooms = new List<Room>();
            edges = new List<Edge>();
            items = new List<Item>();
            npcs = new List<NPC>();
            action = new Action(game: this); // So Action can encapsulate the game logic
            CreateRooms();
            CreateEdges();
            CreateItems();
            InitializeNPCs();
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
            items.Add(new Item(name:"Hamburger", description:"Mhmm burger.", x: 15, y: 15, roomNumber: 9, symbol: "🍔"));
        }

        private void InitializeNPCs()
        {
            npcs.Add(new NPC("Whale", 2));
            npcs.Add(new NPC("Octopus", 3));
            npcs.Add(new NPC("Turtle", 4));
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
            if(items.Where(item => item.RoomNumber == player.Position).ToList().FirstOrDefault() != null){
                possibleMoves.Add('p');
            }
            if(npcs.Where(npc => npc.RoomNumber == player.Position).ToList().FirstOrDefault() != null){
                possibleMoves.Add('t');
            }
            return possibleMoves.ToArray();
        }

        public void Play()
        {
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
                items.Where(item => item.RoomNumber == player.Position).ToList());

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
