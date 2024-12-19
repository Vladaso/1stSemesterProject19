using System.Diagnostics;

namespace WorldOfZuul
{

    public class Game
    {
        public List<Room> rooms {get; private set;}
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
        public PollutionMeter pollutionMeter = new PollutionMeter();

        // HERE we store a bunch of data about the playthrough, that will be displayed on victory.
        public int questionsAsked = 0;
        public int questionsCorrect = 0;
        public List<string> question_sources = new List<string>();
        int movesMade = 0;
        Stopwatch stopwatch = new Stopwatch();

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
            rooms.Add(new Room(10, "Tower", "Placeholder"));

        
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
            items.Add(new Item(name:"Scissors", description:"Might be useful.", x: 22, y: 20, roomNumber: 3, symbol: "✁"));       }

        private void InitializeNPCs()
        {
            npcs.Add(new NPC("Frog", 0));
            npcs.Add(new NPC("Whale", 2));
            npcs.Add(new NPC("Octopus", 3));
            npcs.Add(new NPC("Sealion", 1));
            npcs.Add(new NPC("SeaHorse", 6));
            npcs.Add(new NPC("Turtle", 4));
            npcs.Add(new NPC("Dolphin", 5));
            npcs.Add(new NPC("Crab", 8));
            npcs.Add(new NPC("Scorpion", 7));
            npcs.Add(new NPC("Princess", 10));
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
            possibleMoves.Add('m');
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
            Quizer quizer = new Quizer(game: this);
            stopwatch.Start();
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
                if(pollutionMeter.PollutionLevel >= 100){
                                ConsoleUtils.ClearConsole();
            Console.WriteLine(@"
    ┌────────────────────────────────────────────────────────────────────────────────────┐
    │                            )                                                       │
    │                         ( /(               As fish mayor, you failed to repair     │
    │\ )      )    )     (    )\())  )     (  (      Finlandia's filtration system.      │
    │)/(   ( /(   (     ))\  ((_)\  /((   ))\ )(                                         │
    │(_))_ )(_))  )\  '/((_)   ((_)(_))\ /((_|()\ Microplastics now choke the waters,    │
    │)) __((_)_ _((_))(_))    / _ \_)((_|_))  ((_)      poisoning your home.             │
    │| (_ / _` | '  \() -_)  | (_) \ V // -_)| '_|                                       │
    │ \___\__,_|_|_|_|\___|   \___/ \_/ \___||_|   Your children are born stunted,       │
    │                                                  weaker than ever before.          │
    │                                                                                    │
    │                                             Their children struggle even more,     │
    │                                                as marine life disappears.          │
    │                                                                                    │
    │        |\    \ \ \ \ \ \ \      __              You watch from your perch,         │
    │        |  \    \ \ \ \ \ \ \   | O~-_            untouched by the ruin.            │
    │        |   >----|-|-|-|-|-|-|--|  __/                                              │
    │        |  /    / / / / / / /   |__\         It doesn't affect you directly—        │
    │        |/     / / / / / / /                      but does it feel good?            │
    │                                                                                    │
    │                                                   You failed Finlandia.            │
    │                                                    You failed them all.            │
    │                                                                                    │
    └────────────────────────────────────────────────────────────────────────────────────┘
            ");
                    continuePlaying = false;
                }
                movesMade++;
            }
            stopwatch.Stop();
            Console.WriteLine("You have completed the game!");
            Console.WriteLine($"You were asked {questionsAsked} questions, and answered {questionsCorrect} correctly.");
            Console.WriteLine($"You took {stopwatch.Elapsed.Minutes} minutes and {stopwatch.Elapsed.Seconds} seconds to complete the game.");
            Console.WriteLine($"You made {movesMade} moves.");
            Console.WriteLine($"You ended with {(int) pollutionMeter.PollutionLevel}% pollution.");
            Console.WriteLine("Please share your score so you can be added to the leaderboard.");
            if(question_sources.Count > 0)
            {
            Console.WriteLine("Check out these sources for questions you got wrong:");
            foreach (string source in question_sources)
            {
                Console.WriteLine(source);
            }
            }
        }
    }
}
